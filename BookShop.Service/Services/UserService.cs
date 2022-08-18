using BookShop.Data.DBContext;
using BookShop.Service.Contracts;
using BookShop.Service.Dtos;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace BookShop.Service.Services
{
    public class UserService : IUserService
    {
        //public readonly IConfiguration _configuration;
        //public readonly ILogger<ApplicationUser> _logger;
        //public readonly SignInManager<ApplicationUser> _signInManager;
        //public readonly UserManager<ApplicationUser> _userManager;

        public UserService()
        {
        }

        //public UserService(IConfiguration configuration,
        //                      ILogger<ApplicationUser> logger,
        //                      SignInManager<ApplicationUser> signInManager,
        //                      UserManager<ApplicationUser> userManager)
        //{
        //    _configuration = configuration;
        //    _logger = logger;
        //    _signInManager = signInManager;
        //    _userManager = userManager;
        //}

        //public async Task<bool> Create(AspNetUsersDto model)
        //{
        //    var existingUser = await _userManager.FindByEmailAsync(model.Email);
        //    if (existingUser == null)
        //    {
        //        ApplicationUser user = new ApplicationUser();
        //        user.Email = model.Email;
        //        user.PasswordHash = model.PasswordHash;
        //        user.PhoneNumber = model.PhoneNumber;
        //        user.UserName = model.Email;

        //        IdentityResult result = _userManager.CreateAsync(user, model.PasswordHash).Result;

        //        if (result.Succeeded)
        //        {
        //            await _userManager.AddToRoleAsync(user, "User");
        //            return true;
        //        }
        //    }
        //    return false;
        //}

        //public async Task<bool> LogIn(LogInDto logInDto)
        //{
        //    var result = _signInManager.PasswordSignInAsync(logInDto.Email, logInDto.Password, false, lockoutOnFailure: true).Result;
        //    if (result.Succeeded)
        //    {
        //        var user = await _userManager.FindByEmailAsync(logInDto.Email);
        //        if (user != null)
        //        {
        //            var passwordCheck = await _signInManager.CheckPasswordSignInAsync(user, logInDto.Password, false);
        //            if (passwordCheck.Succeeded)
        //            {
        //                return true;
        //            }
        //            else
        //            {
        //                return false;
        //            }
        //        }
        //        else
        //        {
        //            return false;
        //        }
        //    }
        //    else
        //    {
        //        return false;
        //    }


        //    /*
        //        if (logInDto != null && !string.IsNullOrWhiteSpace(logInDto.Email) && !string.IsNullOrWhiteSpace(logInDto.Password))
        //        {
        //            var conn = new SqlConnection(_configuration["ConnectionStrings:connection"]);
        //            using (conn)
        //            {
        //                SqlCommand cmd = new SqlCommand("select * from AspNetUsers where Email = '" + logInDto.Email + "' + , PasswordHash = '" + logInDto.Password + "'", conn);
        //                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
        //                DataTable dt = new DataTable();
        //                adapter.Fill(dt);

        //                if (dt != null && dt.Rows.Count > 0)
        //                {
        //                    return true;
        //                }
        //                else
        //                {
        //                    return false;
        //                }
        //            }
        //        }
        //        else
        //        {
        //            return false;
        //        }*/

        //}
    }
}
