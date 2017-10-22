using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Models.Models;
using BussinesAccess.Extensions;

namespace TDG_SOLAIRE
{
    public static class CollectionExtensions
    {

        public static List<SelectListItem> ToSelectList<T>(this IEnumerable<T> enumerable, Func<T, string> text, Func<T, string> value, string defaultOption)
        {
            var items = enumerable.Select(f => new SelectListItem() { Text = text(f), Value = value(f) }).ToList();
            items.Insert(0, new SelectListItem() { Text = defaultOption, Value = "-1" });
            return items;
        }
        //public static List<Autocomplete> ToAutoComplete<T>(this IEnumerable<T> enumerable, Func<T, int> Id, Func<T, string> Name)
        //{
        //    return enumerable.Select(f => new Autocomplete() { Id = Id(f), Name = Name(f) }).ToList();
        //}


        //public static List<AutocompleteStringKey> ToAutoComplete<T>(this IEnumerable<T> enumerable, Func<T, string> Id, Func<T, string> Name)
        //{
        //    return enumerable.Select(f => new AutocompleteStringKey() { Id = Id(f), Name = Name(f) }).ToList();
        //}


        public static List<SelectListItem> SexoSelectList()
        {
            return Enum.GetValues(typeof(Sexo)).Cast<Sexo>()
                .Select(c => new SelectListItem { Value = ((int)c).ToString(), Text = c.EnumDescription() }).ToList();
        } 
    }
}

