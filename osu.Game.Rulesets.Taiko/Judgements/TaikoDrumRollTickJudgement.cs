﻿// Copyright (c) 2007-2018 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

using osu.Game.Rulesets.Scoring;

namespace osu.Game.Rulesets.Taiko.Judgements
{
    public class TaikoDrumRollTickJudgement : TaikoJudgement
    {
        public override bool AffectsCombo => false;

        protected override int NumericResultFor(HitResult result)
        {
            switch (result)
            {
                case HitResult.Great:
                    return 200;
                default:
                    return 0;
            }
        }

        protected override double HealthIncreaseFor(HitResult result)
        {
            switch (result)
            {
                case HitResult.Great:
                    return 0.15;
                default:
                    return 0;
            }
        }
    }
}
