using AutoMapper;
using Ninject.Modules;
using TouristAgency.Services;

public class AutoMapperNinjectModule : NinjectModule
{
    public override void Load()
    {
        var mapperConfiguration = CreateConfiguration();
        Bind<MapperConfiguration>().ToConstant(mapperConfiguration).InSingletonScope();

        // This teaches Ninject how to create automapper instances say if for instance
        // MyResolver has a constructor with a parameter that needs to be injected
        Bind<IMapper>().ToMethod(ctx =>
             new Mapper(mapperConfiguration, type => ctx.Kernel.GetBindings(type)));
    }

    private MapperConfiguration CreateConfiguration()
    {
        var config = new MapperConfiguration(cfg =>
        {
            // Add all profiles in current assembly
            cfg.AddProfile<MappingProfile>();
        });

        return config;
    }
}