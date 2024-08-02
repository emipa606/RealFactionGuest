﻿using RimWorld;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using Verse;

namespace raceQuestPawn
{
    public static class ChoosePawn
    {
        public static PawnKindDef ChoosePawnKind(List<PawnGroupMaker> plans, float combatPower)
        {
            var traders = plans.Where(t => t.traders != null).Select(t => t.traders);
            var guards = plans.Where(t => t.guards != null).Select(t => t.guards);
            PawnKindDef p = null;
            if (traders.Any())
            {
                p = ChoosePawnKindInner(traders, combatPower);
            }
            else if (guards.Any())
            {
                p = ChoosePawnKindInner(guards, combatPower);
            }
            if (p == null)
            {
                var options = plans.Where(t => t.options != null).Select(t => t.options);
                p = ChoosePawnKindInner(options, combatPower);
            }
            return p;
        }
        public static PawnKindDef ChoosePawnKindInner(IEnumerable<List<PawnGenOption>> options, float combatPower)
        {
            foreach (var item in options)
            {
                //find all pawnkinds match the condition combatPower +- 30,or combatPower = request.combatPower.
                var pawnToChoose = item.Where(t => Mathf.Abs(t.kind.combatPower - combatPower) < 30f).Select(t => t.kind);
                var pawnEquals = pawnToChoose.Where(t => t.combatPower == combatPower);
                if (pawnToChoose.Any())
                {
                    // only one = request combatPower
                    if (pawnEquals.Count() == 1)
                    {
                        foreach (var item1 in pawnToChoose)
                        {
                            return item1;
                        }
                    }
                    // other situations, get random one
                    else
                    {
                        return pawnToChoose.ToHashSet().RandomElement();
                    }
                }
            }
            return null;
        }
    }
}