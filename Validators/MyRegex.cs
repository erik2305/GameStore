using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GameStore.Validators
{
    public static class MyRegex
    {
        public const string YoutubeRegex = @"^(https:\/\/www\.youtube\.com\/watch\?v=\w+)|^(https:\/\/www\.youtube\.com\/embed\/\w+)|^(https:\/\/youtu\.be\/\w+)";
        public const string NotYoutubeRegex = @"^(https:\/\/www\.youtube\.com\/watch\?v=)|^(https:\/\/www\.youtube\.com\/embed\/)|^(https:\/\/youtu\.be\/)";
    }
}