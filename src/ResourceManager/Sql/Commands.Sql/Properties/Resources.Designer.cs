﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Microsoft.Azure.Commands.Sql.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("Microsoft.Azure.Commands.Sql.Properties.Resources", typeof(Resources).Assembly);
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
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Database with name: &apos;{0}&apos; already exists in server &apos;{1}&apos;..
        /// </summary>
        internal static string DatabaseNameExists {
            get {
                return ResourceManager.GetString("DatabaseNameExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A data masking rule for alias &apos;{0}&apos; is already exists.
        /// </summary>
        internal static string DataMaskingAliasAlreadyUsedError {
            get {
                return ResourceManager.GetString("DataMaskingAliasAlreadyUsedError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot set a lower bound which is larger than the higher bound.
        /// </summary>
        internal static string DataMaskingNumberRuleIntervalDefinitionError {
            get {
                return ResourceManager.GetString("DataMaskingNumberRuleIntervalDefinitionError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The rule {0} does not exist.
        /// </summary>
        internal static string DataMaskingRuleDoesNotExist {
            get {
                return ResourceManager.GetString("DataMaskingRuleDoesNotExist", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A data masking rule for the table &apos;{0}&apos; and column &apos;{1}&apos; already exists.
        /// </summary>
        internal static string DataMaskingTableAndColumnUsedError {
            get {
                return ResourceManager.GetString("DataMaskingTableAndColumnUsedError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to The use of any of these event types is deprecated: DataAccess, SchemaChanges, DataChanges, SecurityExceptions, RevokePermissions.
        /// </summary>
        internal static string DeprecatedEventTypeUsed {
            get {
                return ResourceManager.GetString("DeprecatedEventTypeUsed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Elastic Pool with name: &apos;{0}&apos; already exists in server &apos;{1}&apos;..
        /// </summary>
        internal static string ElasticPoolNameExists {
            get {
                return ResourceManager.GetString("ElasticPoolNameExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {your_password_here}.
        /// </summary>
        internal static string EnterPassword {
            get {
                return ResourceManager.GetString("EnterPassword", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to {your_user_id_here}.
        /// </summary>
        internal static string EnterUserId {
            get {
                return ResourceManager.GetString("EnterUserId", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot use deprecated audit events with the current audit events in the same policy..
        /// </summary>
        internal static string InvalidDeprecatedEventTypeSet {
            get {
                return ResourceManager.GetString("InvalidDeprecatedEventTypeSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot use the &apos;{0}&apos; option with other event types..
        /// </summary>
        internal static string InvalidEventTypeSet {
            get {
                return ResourceManager.GetString("InvalidEventTypeSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot use audit table retention without specifying TableIdentifier. You may want to use &apos;{0}&apos;..
        /// </summary>
        internal static string InvalidRetentionTypeSet {
            get {
                return ResourceManager.GetString("InvalidRetentionTypeSet", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A data masking rule with the id &apos;{0}&apos; already exist.
        /// </summary>
        internal static string NewDataMaskingRuleIdAlreadyExistError {
            get {
                return ResourceManager.GetString("NewDataMaskingRuleIdAlreadyExistError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot set auditing policy without a storage account name..
        /// </summary>
        internal static string NoStorageAccountWhenConfiguringAuditingPolicy {
            get {
                return ResourceManager.GetString("NoStorageAccountWhenConfiguringAuditingPolicy", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to PHP Data Objects(PDO) Sample Code:.
        /// </summary>
        internal static string PdoTitle {
            get {
                return ResourceManager.GetString("PdoTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Error connecting to SQL Server.
        /// </summary>
        internal static string PhpConnectionError {
            get {
                return ResourceManager.GetString("PhpConnectionError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Permanently removing Azure Sql Database &apos;{0}&apos; on server &apos;{1}&apos;..
        /// </summary>
        internal static string RemoveAzureSqlDatabaseDescription {
            get {
                return ResourceManager.GetString("RemoveAzureSqlDatabaseDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Permanently removing Azure Sql Database Elastic Pool &apos;{0}&apos; on server &apos;{1}&apos;..
        /// </summary>
        internal static string RemoveAzureSqlDatabaseElasticPoolDescription {
            get {
                return ResourceManager.GetString("RemoveAzureSqlDatabaseElasticPoolDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove the Azure Sql Database Elastic Pool &apos;{0}&apos; on server &apos;{1}&apos;?.
        /// </summary>
        internal static string RemoveAzureSqlDatabaseElasticPoolWarning {
            get {
                return ResourceManager.GetString("RemoveAzureSqlDatabaseElasticPoolWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove the Azure Sql Database &apos;{0}&apos; on server &apos;{1}&apos;?.
        /// </summary>
        internal static string RemoveAzureSqlDatabaseWarning {
            get {
                return ResourceManager.GetString("RemoveAzureSqlDatabaseWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Permanently removing Azure Sql Database Server &apos;{0}&apos;..
        /// </summary>
        internal static string RemoveAzureSqlServerDescription {
            get {
                return ResourceManager.GetString("RemoveAzureSqlServerDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Permanently removing Firewall Rule &apos;{0}&apos; for Azure Sql Database Server &apos;{1}&apos;..
        /// </summary>
        internal static string RemoveAzureSqlServerFirewallRuleDescription {
            get {
                return ResourceManager.GetString("RemoveAzureSqlServerFirewallRuleDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove the Firewall Rule &apos;{0}&apos; for Azure Sql Database Server  &apos;{1}&apos;?.
        /// </summary>
        internal static string RemoveAzureSqlServerFirewallRuleWarning {
            get {
                return ResourceManager.GetString("RemoveAzureSqlServerFirewallRuleWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove the Azure Sql Database Server &apos;{0}&apos;?.
        /// </summary>
        internal static string RemoveAzureSqlServerWarning {
            get {
                return ResourceManager.GetString("RemoveAzureSqlServerWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Removing firewall rule &quot;{0}&quot; for Microsoft Azure Sql Database &quot;{1}&quot;..
        /// </summary>
        internal static string RemoveDatabaseDataMaskingRuleDescription {
            get {
                return ResourceManager.GetString("RemoveDatabaseDataMaskingRuleDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to remove the data masking rule &quot;{0}&quot; for Microsoft Azure Sql Database &quot;{1}&quot;?.
        /// </summary>
        internal static string RemoveDatabaseDataMaskingRuleWarning {
            get {
                return ResourceManager.GetString("RemoveDatabaseDataMaskingRuleWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Firewall Rule with name: &apos;{0}&apos; already exists for server &apos;{1}&apos;..
        /// </summary>
        internal static string ServerFirewallRuleNameExists {
            get {
                return ResourceManager.GetString("ServerFirewallRuleNameExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Server with name: &apos;{0}&apos; already exists..
        /// </summary>
        internal static string ServerNameExists {
            get {
                return ResourceManager.GetString("ServerNameExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Request for upgrade of server &apos;{0}&apos; already exists..
        /// </summary>
        internal static string ServerUpgradeExists {
            get {
                return ResourceManager.GetString("ServerUpgradeExists", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to A data masking rule with the id &apos;{0}&apos; does not exist.
        /// </summary>
        internal static string SetDataMaskingRuleIdDoesNotExistError {
            get {
                return ResourceManager.GetString("SetDataMaskingRuleIdDoesNotExistError", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Confirm.
        /// </summary>
        internal static string ShouldProcessCaption {
            get {
                return ResourceManager.GetString("ShouldProcessCaption", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SQL Server Extension Sample Code:.
        /// </summary>
        internal static string sqlSampleTitle {
            get {
                return ResourceManager.GetString("sqlSampleTitle", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Azure Sql Database Elastic Pool name is required for this operation.
        /// </summary>
        internal static string StandaloneDatabaseActivityNotSupported {
            get {
                return ResourceManager.GetString("StandaloneDatabaseActivityNotSupported", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Stopping upgrade for Azure Sql Database Server &apos;{0}&apos;..
        /// </summary>
        internal static string StopAzureSqlServerUpgradeDescription {
            get {
                return ResourceManager.GetString("StopAzureSqlServerUpgradeDescription", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Are you sure you want to stop the upgrade for Azure Sql Database Server &apos;{0}&apos;?.
        /// </summary>
        internal static string StopAzureSqlServerUpgradeWarning {
            get {
                return ResourceManager.GetString("StopAzureSqlServerUpgradeWarning", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot find a storage account with the name &apos;{0}&apos;. It either does not exist, associated with a different subscription or you do not have the appropriate credentials to access it..
        /// </summary>
        internal static string StorageAccountNotFound {
            get {
                return ResourceManager.GetString("StorageAccountNotFound", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Cannot use a server&apos;s auditing policy before it is configured..
        /// </summary>
        internal static string UseServerWithoutStorageAccount {
            get {
                return ResourceManager.GetString("UseServerWithoutStorageAccount", resourceCulture);
            }
        }
    }
}
