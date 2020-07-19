﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Devscord.DiscordFramework.Framework.Commands.Responses.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Responses {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Responses() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Devscord.DiscordFramework.Framework.Commands.Responses.Resources.Responses", typeof(Responses).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dodano wszystkie role pomyślnie użytkownikowi {{user}}.
        /// </summary>
        public static string AllRolesAddedToUser {
            get {
                return ResourceManager.GetString("AllRolesAddedToUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usunięto wszystkie role pomyślnie użytkownikowi {{user}}.
        /// </summary>
        public static string AllRolesRemovedFromUser {
            get {
                return ResourceManager.GetString("AllRolesRemovedFromUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Zmieniono ustawienia wszystkich powyższych roli pomyślnie.
        /// </summary>
        public static string AllRolesSettingsChanged {
            get {
                return ResourceManager.GetString("AllRolesSettingsChanged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Podane argumenty są zduplikowane..
        /// </summary>
        public static string ArgumentsDuplicated {
            get {
                return ResourceManager.GetString("ArgumentsDuplicated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dostępne role: {{roles}}.
        /// </summary>
        public static string AvailableSafeRoles {
            get {
                return ResourceManager.GetString("AvailableSafeRoles", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Podane argumenty są niepoprawne.
        /// </summary>
        public static string InvalidArguments {
            get {
                return ResourceManager.GetString("InvalidArguments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Użytkownik {{user}} został wyciszony do {{timeEnd}}.
        /// </summary>
        public static string MutedUser {
            get {
                return ResourceManager.GetString("MutedUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cześć {{user}}! Witamy cię na serwerze {{server}}.
        /// </summary>
        public static string NewUserArrived {
            get {
                return ResourceManager.GetString("NewUserArrived", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nie masz wystarczających uprawnień do wywołania tej komendy..
        /// </summary>
        public static string NotAdminPermissions {
            get {
                return ResourceManager.GetString("NotAdminPermissions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Podano niewystarczającą liczbę argumentów!.
        /// </summary>
        public static string NotEnoughArguments {
            get {
                return ResourceManager.GetString("NotEnoughArguments", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Liczba wiadomości w podanym zakresie jest ogromna ({{messagesCount}} wiadomości). Czy na pewno chcesz wszystkie przeczytać? (użyj parametru -force).
        /// </summary>
        public static string NumberOfMessagesIsHuge {
            get {
                return ResourceManager.GetString("NumberOfMessagesIsHuge", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Odpowiedź `{{onEvent}}` już istnieje dla serwera **{{server}}**..
        /// </summary>
        public static string ResponseAlreadyExists {
            get {
                return ResourceManager.GetString("ResponseAlreadyExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Odpowiedź `{{onEvent}}` została dodana dla serwera **{{server}}**..
        /// </summary>
        public static string ResponseHasBeenAdded {
            get {
                return ResourceManager.GetString("ResponseHasBeenAdded", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Odpowiedź `{{onEvent}}` została usunięta dla serwera **{{server}}**..
        /// </summary>
        public static string ResponseHasBeenRemoved {
            get {
                return ResourceManager.GetString("ResponseHasBeenRemoved", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Odpowiedź `{{onEvent}}` została zaktualizowana dla serwera **{{server}}**.\nStara odpowiedź: *{{oldMessage}}*.\nNowa odpowiedź: *{{newMessage}}*..
        /// </summary>
        public static string ResponseHasBeenUpdated {
            get {
                return ResourceManager.GetString("ResponseHasBeenUpdated", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Odpowiedź `{{onEvent}}` nie została odnaleziona dla serwera **{{server}}**..
        /// </summary>
        public static string ResponseNotFound {
            get {
                return ResourceManager.GetString("ResponseNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Dodano role: {{role}} użytkownikowi {{user}}.
        /// </summary>
        public static string RoleAddedToUser {
            get {
                return ResourceManager.GetString("RoleAddedToUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Użytkownik {{user}} posiada już role {{role}}.
        /// </summary>
        public static string RoleIsInUserAlready {
            get {
                return ResourceManager.GetString("RoleIsInUserAlready", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Rola &quot;{{role}}&quot; już jest ustawiona jako bezpieczna..
        /// </summary>
        public static string RoleIsSafeAlready {
            get {
                return ResourceManager.GetString("RoleIsSafeAlready", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Rola &quot;{{role}}&quot; nie jest już ustawiona jako bezpieczna.
        /// </summary>
        public static string RoleIsUnsafeAlready {
            get {
                return ResourceManager.GetString("RoleIsUnsafeAlready", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nie znaleziono roli {{role}}..
        /// </summary>
        public static string RoleNotFound {
            get {
                return ResourceManager.GetString("RoleNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Użytkownik {{user}} nie posiada roli {{role}}.
        /// </summary>
        public static string RoleNotFoundInUser {
            get {
                return ResourceManager.GetString("RoleNotFoundInUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nie znaleziono roli {{role}} lub wybrana rola musi być zmieniona ręcznie przez członka administracji.
        /// </summary>
        public static string RoleNotFoundOrIsNotSafe {
            get {
                return ResourceManager.GetString("RoleNotFoundOrIsNotSafe", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Usunięto role {{role}} użytkownikowi {{user}}.
        /// </summary>
        public static string RoleRemovedFromUser {
            get {
                return ResourceManager.GetString("RoleRemovedFromUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Zmieniono ustawienia roli {{role}} pomyślnie!.
        /// </summary>
        public static string RoleSettingsChanged {
            get {
                return ResourceManager.GetString("RoleSettingsChanged", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Wysłano {{messagesCount}} wiadomości użytkownika {{user}} w wiadomości prywatnej..
        /// </summary>
        public static string SentByDmMessagesOfAskedUser {
            get {
                return ResourceManager.GetString("SentByDmMessagesOfAskedUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Serwer nie ma żadnych dostępnych bezpiecznych ról (jeśli jesteś adminem, ustaw bezpieczne role za pomocą komendy -set role &lt;nazwa_roli&gt; safe) .
        /// </summary>
        public static string ServerDoesntHaveAnySafeRoles {
            get {
                return ResourceManager.GetString("ServerDoesntHaveAnySafeRoles", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Spam alert! Wykryto spam u użytkownika {{user}} na kanale {{channel}}. Poczekaj chwile zanim coś napiszesz..
        /// </summary>
        public static string SpamAlertRecognized {
            get {
                return ResourceManager.GetString("SpamAlertRecognized", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Czas nie może być ujemny!.
        /// </summary>
        public static string TimeCannotBeNegative {
            get {
                return ResourceManager.GetString("TimeCannotBeNegative", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Podano za dużą wartość czasu!.
        /// </summary>
        public static string TimeIsTooBig {
            get {
                return ResourceManager.GetString("TimeIsTooBig", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nie określiłeś przedziału czasu!.
        /// </summary>
        public static string TimeNotSpecified {
            get {
                return ResourceManager.GetString("TimeNotSpecified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Użytkownik {{user}} może pisać ponownie..
        /// </summary>
        public static string UnmutedUser {
            get {
                return ResourceManager.GetString("UnmutedUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cześć {{user}}! Już możesz pisać ponownie na serwerze {{server}}.
        /// </summary>
        public static string UnmutedUserForUser {
            get {
                return ResourceManager.GetString("UnmutedUserForUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Nie wskazałeś żadnego użytkownika!.
        /// </summary>
        public static string UserDidntMentionAnyUser {
            get {
                return ResourceManager.GetString("UserDidntMentionAnyUser", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Użytkownik {{user}} nie napisał żadnej wiadomości w podanym czasie..
        /// </summary>
        public static string UserDidntWriteAnyMessageInThisTime {
            get {
                return ResourceManager.GetString("UserDidntWriteAnyMessageInThisTime", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Użytkownik {{user}} nie posiada avatara..
        /// </summary>
        public static string UserDoesntHaveAvatar {
            get {
                return ResourceManager.GetString("UserDoesntHaveAvatar", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Użytkownik {{user}} nie istnieje..
        /// </summary>
        public static string UserNotFound {
            get {
                return ResourceManager.GetString("UserNotFound", resourceCulture);
            }
        }
    }
}
