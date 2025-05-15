using Autofac;
using DbContext;
using Files;
using Repository;
using Repository.Interfaces;
using Services;
using Services.Interfaces;
using Validation;
using Validation.Interfaces;

namespace Modules;

public class AppModule : Module
{
    protected override void Load(ContainerBuilder builder)
    {
        builder.RegisterType<ParseFromFile>().As<IParseFromFile>();
        builder.RegisterType<ReadFromFile>().As<IReadFromFile>();
        builder.RegisterType<CsvFileValidation>().As<IFileValidation>();
        builder.RegisterType<ContactRepositroy>().As<IContactRepository>();
        builder.RegisterType<ExcelFile>();
        builder.RegisterType<AppDbContext>();

    }
}