﻿using CoreDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace CoreDemo.ViewComponents
{
	public class CommentList :ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var commentvalues = new List<UserComment> {
				new UserComment
				{
					ID=1,
					Username="Hakan"
				},

				new UserComment
				{
					ID=2,
					Username="Emre"
				},
				  new UserComment
				{
					ID=3,
					Username="Merve"
				},
			};
			return View(commentvalues);
		}
	}
}
