using AutoMapper;
using AutoMapperApp.Models;
using AutoMapperApp.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace AutoMapperApp.Controllers
{
    public class UserController : Controller
    {
        private readonly IMapper _mapper;

        public UserController(IMapper mapper)
        {
            _mapper = mapper;
        }
        public IActionResult Index()
        {
            var userDetails = GetUserDetails();
            var UserViewModelDetails = _mapper.Map<UserViewModel>(userDetails);
            return View(UserViewModelDetails);
        }
        private static User GetUserDetails()
        {
            return new User
            {
                Id = 1,
                FirstName = "Sneha",
                LastName = "Misra",
                Email = "Sneha.Misra05@gmail.com"
            };
        }
    }
}
