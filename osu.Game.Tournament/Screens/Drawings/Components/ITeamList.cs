﻿// Copyright (c) 2007-2018 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using System.Collections.Generic;
using osu.Game.Tournament.Components;

namespace osu.Game.Tournament.Screens.Drawings.Components
{
    public interface ITeamList
    {
        IEnumerable<TournamentTeam> Teams { get; }
    }
}
