using AutoMapper;

namespace TorrentBox.TransmisssionClient.Mapper
{
    public static class MapperSingleton
    {
        private static IMapper mapper;

        public static IMapper MapperInstance
        {
            get { return mapper ?? (mapper = MapperSingleton.CreateMapper()); }
            set { mapper = value; }
        }

        private static IMapper CreateMapper()
        {
            var config = new MapperConfiguration(cfg => {
                cfg.AddProfile<MapperProfile>();             
            });
            return config.CreateMapper();
        }
    }
}
