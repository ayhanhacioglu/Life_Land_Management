﻿using System;
using System.Configuration;
using DevExpress.ExpressApp;
using DevExpress.Persistent.Base;
using System.ComponentModel;
using DevExpress.ExpressApp.Mobile;
using System.Collections.Generic;
using DevExpress.ExpressApp.Xpo;
using DevExpress.ExpressApp.Security;
using DevExpress.ExpressApp.Security.ClientServer;

namespace LifeLandManagement.Mobile {
    // For more typical usage scenarios, be sure to check out https://docs.devexpress.com/eXpressAppFramework/DevExpress.ExpressApp.Mobile.MobileApplication
    public partial class LifeLandManagementMobileApplication : MobileApplication {
        private DevExpress.ExpressApp.SystemModule.SystemModule module1;
        private DevExpress.ExpressApp.Mobile.SystemModule.SystemMobileModule module2;
        private LifeLandManagement.Module.LifeLandManagementModule module3;
        private LifeLandManagement.Module.Mobile.LifeLandManagementMobileModule module4;
        private DevExpress.ExpressApp.Security.SecurityModule securityModule1;
        private DevExpress.ExpressApp.Security.SecurityStrategyComplex securityStrategyComplex1;
        private DevExpress.ExpressApp.Security.AuthenticationStandard authenticationStandard1;
        private DevExpress.ExpressApp.AuditTrail.AuditTrailModule auditTrailModule;
        private DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule objectsModule;
        private DevExpress.ExpressApp.ConditionalAppearance.ConditionalAppearanceModule conditionalAppearanceModule;
        private DevExpress.ExpressApp.ConditionalAppearance.Mobile.ConditionalAppearanceMobileModule conditionalAppearanceMobileModule;
        private DevExpress.ExpressApp.Dashboards.DashboardsModule dashboardsModule;
        private DevExpress.ExpressApp.FileAttachments.Mobile.FileAttachmentsMobileModule fileAttachmentsMobileModule;
        private DevExpress.ExpressApp.Localization.Mobile.LocalizationMobileModule localizationMobileModule;
        private DevExpress.ExpressApp.ReportsV2.ReportsModuleV2 reportsModuleV2;
        private DevExpress.ExpressApp.ReportsV2.Mobile.ReportsMobileModuleV2 reportsMobileModuleV2;
        private DevExpress.ExpressApp.Validation.ValidationModule validationModule;
        private DevExpress.ExpressApp.Validation.Mobile.ValidationMobileModule validationMobileModule;

        #region Default XAF configuration options (https://www.devexpress.com/kb=T501418)
        static LifeLandManagementMobileApplication() {
            DevExpress.Persistent.Base.PasswordCryptographer.EnableRfc2898 = true;
            DevExpress.Persistent.Base.PasswordCryptographer.SupportLegacySha512 = false;
            DevExpress.ExpressApp.Mobile.MobileApplication.EnableExtendedDetailViewLayout = true;
        }
        private void InitializeDefaults() {
            LinkNewObjectToParentImmediately = false;
        }
        #endregion
        public LifeLandManagementMobileApplication() {
            Tracing.Initialize();
            if(ConfigurationManager.ConnectionStrings["ConnectionString"] != null) {
                ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
            }
#if EASYTEST
            if(ConfigurationManager.ConnectionStrings["EasyTestConnectionString"] != null) {
                ConnectionString = ConfigurationManager.ConnectionStrings["EasyTestConnectionString"].ConnectionString;
            }
#endif
            InitializeComponent();
            SecurityStrategy security = (SecurityStrategy)Security;
            security.RegisterXPOAdapterProviders();
			InitializeDefaults();
#if DEBUG
            if(System.Diagnostics.Debugger.IsAttached && CheckCompatibilityType == CheckCompatibilityType.DatabaseSchema) {
                DatabaseUpdateMode = DatabaseUpdateMode.UpdateDatabaseAlways;
            }
#endif
        }
        protected override void SetLogonParametersForUIBuilder(object logonParameters) {
            base.SetLogonParametersForUIBuilder(logonParameters);
            ((AuthenticationStandardLogonParameters)logonParameters).UserName = "Admin";
            ((AuthenticationStandardLogonParameters)logonParameters).Password = "";
        }
        protected override void CreateDefaultObjectSpaceProvider(CreateCustomObjectSpaceProviderEventArgs args) {
            args.ObjectSpaceProvider = new SecuredObjectSpaceProvider((SecurityStrategyComplex)Security, GetDataStoreProvider(args.ConnectionString, args.Connection), true);
            args.ObjectSpaceProviders.Add(new NonPersistentObjectSpaceProvider(TypesInfo, null));
        }
        private IXpoDataStoreProvider GetDataStoreProvider(string connectionString, System.Data.IDbConnection connection) {
            System.Web.HttpApplicationState application = (System.Web.HttpContext.Current != null) ? System.Web.HttpContext.Current.Application : null;
            IXpoDataStoreProvider dataStoreProvider = null;
            if(application != null && application["DataStoreProvider"] != null) {
                dataStoreProvider = application["DataStoreProvider"] as IXpoDataStoreProvider;
            }
            else {
                dataStoreProvider = XPObjectSpaceProvider.GetDataStoreProvider(connectionString, connection, true);
                if(application != null) {
                    application["DataStoreProvider"] = dataStoreProvider;
                }
            }
            return dataStoreProvider;
        }
        private void LifeLandManagementMobileApplication_DatabaseVersionMismatch(object sender, DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs e) {
#if EASYTEST
            e.Updater.Update();
            e.Handled = true;
#else
            if(System.Diagnostics.Debugger.IsAttached) {
                e.Updater.Update();
                e.Handled = true;
            }
            else {
                string message = "The application cannot connect to the specified database, " +
                    "because the database doesn't exist, its version is older " +
                    "than that of the application or its schema does not match " +
                    "the ORM data model structure. To avoid this error, use one " +
                    "of the solutions from the https://www.devexpress.com/kb=T367835 KB Article.";

                if(e.CompatibilityError != null && e.CompatibilityError.Exception != null) {
                    message += "\r\n\r\nInner exception: " + e.CompatibilityError.Exception.Message;
                }
                throw new InvalidOperationException(message);
            }
#endif
        }
        private void InitializeComponent() {
            this.module1 = new DevExpress.ExpressApp.SystemModule.SystemModule();
            this.module2 = new DevExpress.ExpressApp.Mobile.SystemModule.SystemMobileModule();
            this.module3 = new LifeLandManagement.Module.LifeLandManagementModule();
            this.module4 = new LifeLandManagement.Module.Mobile.LifeLandManagementMobileModule();
            this.securityModule1 = new DevExpress.ExpressApp.Security.SecurityModule();
            this.securityStrategyComplex1 = new DevExpress.ExpressApp.Security.SecurityStrategyComplex();
            this.authenticationStandard1 = new DevExpress.ExpressApp.Security.AuthenticationStandard();
            this.auditTrailModule = new DevExpress.ExpressApp.AuditTrail.AuditTrailModule();
            this.objectsModule = new DevExpress.ExpressApp.Objects.BusinessClassLibraryCustomizationModule();
            this.conditionalAppearanceModule = new DevExpress.ExpressApp.ConditionalAppearance.ConditionalAppearanceModule();
            this.conditionalAppearanceMobileModule = new DevExpress.ExpressApp.ConditionalAppearance.Mobile.ConditionalAppearanceMobileModule();
            this.dashboardsModule = new DevExpress.ExpressApp.Dashboards.DashboardsModule();
            this.fileAttachmentsMobileModule = new DevExpress.ExpressApp.FileAttachments.Mobile.FileAttachmentsMobileModule();
            this.localizationMobileModule = new DevExpress.ExpressApp.Localization.Mobile.LocalizationMobileModule();
            this.reportsModuleV2 = new DevExpress.ExpressApp.ReportsV2.ReportsModuleV2();
            this.reportsMobileModuleV2 = new DevExpress.ExpressApp.ReportsV2.Mobile.ReportsMobileModuleV2();
            this.validationModule = new DevExpress.ExpressApp.Validation.ValidationModule();
            this.validationMobileModule = new DevExpress.ExpressApp.Validation.Mobile.ValidationMobileModule();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // securityStrategyComplex1
            // 
            this.securityStrategyComplex1.Authentication = this.authenticationStandard1;
            this.securityStrategyComplex1.RoleType = typeof(DevExpress.Persistent.BaseImpl.PermissionPolicy.PermissionPolicyRole);
            this.securityStrategyComplex1.UserType = typeof(DevExpress.Persistent.BaseImpl.PermissionPolicy.PermissionPolicyUser);
            // 
            // securityModule1
            // 
            this.securityModule1.UserType = typeof(DevExpress.Persistent.BaseImpl.PermissionPolicy.PermissionPolicyUser);
            // 
            // authenticationStandard1
            // 
            this.authenticationStandard1.LogonParametersType = typeof(DevExpress.ExpressApp.Security.AuthenticationStandardLogonParameters);
            //
            // auditTrailModule
            //
            this.auditTrailModule.AuditDataItemPersistentType = typeof(DevExpress.Persistent.BaseImpl.AuditDataItemPersistent);
            //
            // dashboardsModule
            //
            this.dashboardsModule.DashboardDataType = typeof(DevExpress.Persistent.BaseImpl.DashboardData);
            //
            // reportsModuleV2
            //
            this.reportsModuleV2.EnableInplaceReports = true;
            this.reportsModuleV2.ReportDataType = typeof(DevExpress.Persistent.BaseImpl.ReportDataV2);
            this.reportsModuleV2.ShowAdditionalNavigation = false;
            this.reportsModuleV2.ReportStoreMode = DevExpress.ExpressApp.ReportsV2.ReportStoreModes.XML;
            // 
            // LifeLandManagementMobileApplication
            // 
            this.ApplicationName = "LifeLandManagement";
            this.Modules.Add(this.module1);
            this.Modules.Add(this.module2);
            this.Modules.Add(this.module3);
            this.Modules.Add(this.module4);
            this.Modules.Add(this.securityModule1);
            this.Security = this.securityStrategyComplex1;
            this.Modules.Add(this.auditTrailModule);
            this.Modules.Add(this.objectsModule);
            this.Modules.Add(this.conditionalAppearanceModule);
            this.Modules.Add(this.conditionalAppearanceMobileModule);
            this.Modules.Add(this.dashboardsModule);
            this.Modules.Add(this.fileAttachmentsMobileModule);
            this.Modules.Add(this.localizationMobileModule);
            this.Modules.Add(this.reportsModuleV2);
            this.Modules.Add(this.reportsMobileModuleV2);
            this.Modules.Add(this.validationModule);
            this.Modules.Add(this.validationMobileModule);
            this.DatabaseVersionMismatch += new System.EventHandler<DevExpress.ExpressApp.DatabaseVersionMismatchEventArgs>(this.LifeLandManagementMobileApplication_DatabaseVersionMismatch);
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }
    }
}
