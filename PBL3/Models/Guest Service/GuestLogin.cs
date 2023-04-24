
using Microsoft.AspNetCore.Mvc;
using PBL3.Models.Entities;

namespace PBL3.Models.Guest_Service
{
	public class GuestLogin : IGuestLogin
	{
		private readonly LibraryManagementContext DB;

		public GuestLogin(LibraryManagementContext libraryManagementContext)
		{
			DB = libraryManagementContext;
		}

		public int Login(AccountLogin a)
		{
			var y = DB.AccountLogins.Where(p => p.PassHashCode == a.PassHashCode && p.AccName == a.AccName);
			a = y.Single();
			return 0;
			throw new NotImplementedException();
		}
	}
}
