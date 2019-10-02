﻿using NPoco;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UIOMatic.Attributes;
using Umbraco.Core.Persistence.DatabaseAnnotations;

namespace UIOMatic
{
    [UIOMatic("people", "People", "Person", FolderIcon = "icon-users", ItemIcon = "icon-user", RenderType =Enums.UIOMaticRenderType.List, ShowOnSummaryDashboard = true)]
    [TableName("People")]
    public class Person
    {
        [PrimaryKeyColumn(AutoIncrement = true)]
        public int Id { get; set; }

        [Required]
        [UIOMaticListViewField]
        [UIOMaticField(Name = "First name", Description = "Enter the persons first name")]
        public string FirstName { get; set; }

        [Required]
        [UIOMaticListViewField]
        [UIOMaticField(Name = "Last name", Description = "Enter the persons last name")]
        public string LastName { get; set; }

        //[UIOMaticField(Name = "Picture", Description = "Select a picture", View = UIOMatic.Constants.FieldEditors.File)]
        //public string Picture { get; set; }

        public override string ToString()
        {
            return FirstName + " " + LastName;
        }

    }
}
