using System.Reflection;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Modules;
using Abp.Zero;
using Abp.Zero.Configuration;
using Demo.TestEffortWithEfDynamicFilters.Authorization;
using Demo.TestEffortWithEfDynamicFilters.Authorization.Roles;
using Demo.TestEffortWithEfDynamicFilters.Authorization.Users;
using Demo.TestEffortWithEfDynamicFilters.Configuration;
using Demo.TestEffortWithEfDynamicFilters.MultiTenancy;

namespace Demo.TestEffortWithEfDynamicFilters
{
    [DependsOn(typeof(AbpZeroCoreModule))]
    public class TestEffortWithEfDynamicFiltersCoreModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Auditing.IsEnabledForAnonymousUsers = true;

            //Declare entity types
            Configuration.Modules.Zero().EntityTypes.Tenant = typeof(Tenant);
            Configuration.Modules.Zero().EntityTypes.Role = typeof(Role);
            Configuration.Modules.Zero().EntityTypes.User = typeof(User);

            //Remove the following line to disable multi-tenancy.
            Configuration.MultiTenancy.IsEnabled = TestEffortWithEfDynamicFiltersConsts.MultiTenancyEnabled;

            //Add/remove localization sources here
            Configuration.Localization.Sources.Add(
                new DictionaryBasedLocalizationSource(
                    TestEffortWithEfDynamicFiltersConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        Assembly.GetExecutingAssembly(),
                        "Demo.TestEffortWithEfDynamicFilters.Localization.Source"
                        )
                    )
                );

            AppRoleConfig.Configure(Configuration.Modules.Zero().RoleManagement);

            Configuration.Authorization.Providers.Add<TestEffortWithEfDynamicFiltersAuthorizationProvider>();

            Configuration.Settings.Providers.Add<AppSettingProvider>();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
