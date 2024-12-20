﻿using MentorProjectWebApp.Providers;
using MentorProjectWebApp.Services.MentorStatisticServices;
using Microsoft.AspNetCore.Mvc;

namespace MentorProjectWebApp.ViewComponents.AboutViewComponents
{
    public class _AboutStatisticsComponentPartial : ViewComponent
    {
        private readonly string _componentPath;
        private readonly IMentorStatisticService _statisticService;
        public _AboutStatisticsComponentPartial(IMentorStatisticService statisticService)
        {
            _componentPath = ComponentPathProvider.GetComponentPath(GetType().Name);
            _statisticService = statisticService;
        }
        public async Task<IViewComponentResult> InvokeAsync(int id)
        {
            var values = await _statisticService.GetStatisticByMentorId(id);
            return View(_componentPath, values);
        }
    }
}
