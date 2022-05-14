﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace XIV.Utils
{
    /// <summary>
    /// Utilities for <see cref="Form"/> class
    /// </summary>
    public static class FormUtils
    {
        /// <summary>
        /// Close all forms but keep the ones that has same type with <typeparamref name="T"/>
        /// </summary>
        public static void CloseAllBut<T>() where T : Form
        {
            Type type = typeof(T);
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() != type)
                {
                    form.Close();
                }
                else
                {
                    form.Show();
                    form.Activate();
                }
            }
        }

        /// <summary>
        /// Close all Forms type of <typeparamref name="T"/>
        /// </summary>
        public static void CloseAllInstance<T>() where T : Form
        {
            Type type = typeof(T);
            foreach (Form item in Application.OpenForms)
            {
                if(item.GetType() != type)
                {
                    item.Close();
                }
            }
        }

        /// <summary>
        /// If any <typeparamref name="T"/> type form is open, 
        /// sets <paramref name="form"/> value as giving type and returns true
        /// </summary>
        /// <typeparam name="T">Form Type</typeparam>
        /// <param name="form">null if form is not open</param>
        /// <returns>True if form is open</returns>
        public static bool GetForm<T>(out T form) where T : Form
        {
            Type type = typeof(T);
            form = null;
            foreach (Form item in Application.OpenForms)
            {
                if(item.GetType() == type)
                {
                    form = (T)item;
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// If form is open returns form, else returns new form of type <typeparamref name="T"/>
        /// </summary>
        /// <typeparam name="T">Form Type</typeparam>
        public static T OpenForm<T>(Form mdiParent, bool show = true) where T : Form
        {
            if(GetForm<T>(out T form))
            {
                form.MdiParent = mdiParent;
                if (show)
                {
                    form.Show();
                    //TODO : Do we need Activate call?
                    form.Activate();
                }
                return form;
            }
            form = CreateForm<T>();
            form.MdiParent = mdiParent;
            if (show)
            {
                form.Show();
                //TODO : Do we need Activate call?
                form.Activate();
            }
            return form;
        }

        /// <summary>
        /// Creates a form type of <typeparamref name="T"/>
        /// </summary>
        public static T CreateForm<T>() where T : Form
        {
            return (T)Activator.CreateInstance(typeof(T));
        }

        /// <summary>
        /// Creates a new column with giving <paramref name="DataPropertyName"/> and <paramref name="Header"/> 
        /// and returns it
        /// </summary>
        /// <param name="DataPropertyName"></param>
        /// <param name="Header"></param>
        /// <returns>A new <see cref="DataGridViewColumn"/></returns>
        public static DataGridViewColumn CreateColumn(string DataPropertyName, string Header)
        {
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.Name = DataPropertyName;
            column.DataPropertyName = DataPropertyName;
            column.HeaderText = Header;
            return column;
        }

        /// <summary>
        /// Clears the <paramref name="comboBox"/> and fills with giving <typeparamref name="T"/> values where T is an Enum
        /// </summary>
        /// <typeparam name="T">The enum to get values</typeparam>
        /// <param name="comboBox"><see cref="ComboBox"/> to fill</param>
        public static void FillComboBox_WithEnum<T>(ComboBox comboBox) where T : Enum
        {
            comboBox.Items.Clear();
            Array values = EnumUtils.GetValues<T>();
            foreach (object item in values)
            {
                comboBox.Items.Add(item.ToString());
            }
            if(comboBox.SelectedIndex == -1 && comboBox.Items.Count > 0)
            {
                comboBox.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// Clears the <paramref name="comboBox"/> and fills with giving <paramref name="itemList"/>
        /// </summary>
        /// <param name="comboBox"><see cref="ComboBox"/> to refresh</param>
        /// <param name="itemList">Values for filling the <paramref name="comboBox"/></param>
        public static void RefreshComboBox(ComboBox comboBox, List<object> itemList)
        {
            comboBox.Items.Clear();
            foreach (object item in itemList)
            {
                comboBox.Items.Add(item);
            }
            if(comboBox.SelectedIndex == -1 && comboBox.Items.Count > 0)
            {
                comboBox.SelectedIndex = 0;
            }
        }

        public static T CreateDraggableControl<T>() where T : Control
        {
            Control control = Activator.CreateInstance<T>();
            control.AllowDrop = true;
            return (T)control;
        }

    }

}