﻿using System;

namespace ManualDataBinding.Data
{
    /// <summary>
    /// A class representing a note
    /// </summary>
    public class Note
    {
        public event EventHandler NoteChangedEvent;
        
        private string title = DateTime.Now.ToString();
        /// <summary>
        /// The title of the Note
        /// </summary>
        public string Title
        {
            get { return title; }
            set
            {
                if (title == value) return;
                title = value;
                NoteChangedEvent?.Invoke(this, new EventArgs());
            }
        }

        private string body = "";
        /// <summary>
        /// The text of the note
        /// </summary>
        public string Body
        {
            get { return body; }
            set
            {
                if (title == value) return;
                body = value;
                NoteChangedEvent?.Invoke(this, new EventArgs());
            }
        }
    }
}
