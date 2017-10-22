
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using Models;
using System.Web.Mvc.Ajax;
using System.Web.WebPages;

namespace TDG_SOLAIRE
{
    public static class AutocompleteHelpers
    {
        public static MvcHtmlString AutocompleteFor<TModel, TProperty1, TProperty2>(this HtmlHelper<TModel> html, Expression<Func<TModel, TProperty1>> valueExpression,
            Expression<Func<TModel, TProperty2>> idExpression, string actionName, string controllerName, bool requestFocus, int minlength = 3)
        {
            string autocompleteUrl = UrlHelper.GenerateUrl(null, actionName, controllerName,
                                                           null,
                                                           html.RouteCollection,
                                                           html.ViewContext.RequestContext,
                                                           includeImplicitMvcValues: true);
            string @class = "form-control typeahead" + (requestFocus ? " focus" : string.Empty);
            // Get the fully qualified class name of the autocomplete id field
            string idFieldString = idExpression.Body.ToString();
            // We need to strip the 'model.' from the beginning
            int loc = idFieldString.IndexOf('.');
            // Also, replace the . with _ as this is done by MVC so the field name is js friendly
            string autocompleteIdField = idFieldString.Substring(loc + 1, idFieldString.Length - loc - 1).Replace('.', '_');

            return html.TextBoxFor(valueExpression, new { data_autocomplete_url = autocompleteUrl, @class, data_autocomplete_id_field = autocompleteIdField, data_min_length = minlength });
        }

        public static MvcHtmlString AutocompleteFor<TModel, TProperty1, TProperty2>(this HtmlHelper<TModel> html, Expression<Func<TModel, TProperty1>> valueExpression,
         Expression<Func<TModel, TProperty2>> idExpression, string actionName, string controllerName, bool requestFocus, bool required, int minlength = 3)
        {
            string autocompleteUrl = UrlHelper.GenerateUrl(null, actionName, controllerName,
                                                           null,
                                                           html.RouteCollection,
                                                           html.ViewContext.RequestContext,
                                                           includeImplicitMvcValues: true);
            string @class = "form-control typeahead" + (requestFocus ? " focus" : string.Empty);
            // Get the fully qualified class name of the autocomplete id field
            string idFieldString = idExpression.Body.ToString();
            // We need to strip the 'model.' from the beginning
            int loc = idFieldString.IndexOf('.');
            // Also, replace the . with _ as this is done by MVC so the field name is js friendly
            string autocompleteIdField = idFieldString.Substring(loc + 1, idFieldString.Length - loc - 1).Replace('.', '_');

            return html.TextBoxFor(valueExpression, new { data_autocomplete_url = autocompleteUrl, @class, data_autocomplete_id_field = autocompleteIdField, data_min_length = minlength, Required = "Required" });
        }
        public static MvcHtmlString BoostStrapModal(this HtmlHelper Helper, string modalId, string customTarget = null, bool useLargeModal = false)
        {
            return Helper.Partial("GeneralModal", new ModalViewModel() { ModalName = modalId, CustomtargetId = customTarget, LargeModal = useLargeModal });
        }

    }
}