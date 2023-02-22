using AutoMapper;

namespace Business.Mapper;

internal class LibProfile : Profile
{
    public LibProfile()
    {
        // CreateMap<Contracts.Database.Book, Contracts.ApiDTO.GetAllBooks.BookDto>()
        //     .ForMember(
        //         dest => dest.Rating,
        //         rating => rating.MapFrom(bk => bk.Ratings.Select(rt => rt.Score).Average())
        //     )
        //     .ForMember(dest => dest.RevieswsNumber, rw => rw.MapFrom(bk => bk.Reviews.Count()));

        // CreateProjection<Contracts.Database.Book, Contracts.ApiDTO.GetAllBooks.BookDto>()
        //     .ForMember(
        //         dest => dest.Rating,
        //         rating => rating.MapFrom(bk => bk.Ratings.Select(rt => rt.Score).Average())
        //     )
        //     .ForMember(dest => dest.RevieswsNumber, rw => rw.MapFrom(bk => bk.Reviews.Count()));

        // CreateMap<Contracts.Database.Book, Contracts.ApiDTO.BookDTO>();
    }
}
