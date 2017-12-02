﻿using AdventOfCode.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Days
{
    public class Day1
    {
        private Day1() {
        }

        private static string inputString = "5228833336355848549915459366737982598312959583817455621545976784792489468198365998232722734876612332352376192813552949814275947575774339529811976644361517795586998319242241614813622734255797569571577699238592667287428166398221572885869416419682687759743978434571821267146514338394624525648338739929479912368172669885577319718389278168766844487948761697438722556857882433224393723131298876252626643517236883999115665656935521675772866516185899317132494716723615493476397115627687887665194781746377341468995954554518252916859227397693885254329628812355612487594445522395853551734567498838382248616137969637971369615443599973588326388792893969924855316437952313492551671545714262784738343517166544197194547173515155927244175447296474282154114951181648317875827525814453758846194548872789943372281952995222779173812444186491115426476188672253249744478946863317915136832199132868917891243591195719354721129116229164688256853628339233919671468781913167415624214152793864585332944468428849171876873433621524242289488135675313544498245498637424139153782925723745249728743885493877792648576673196889949568317234125863369187953788611841388353999875519172896329524346527265231767868839696693328273381772726782949166112932954356923757485139367298699922984925977724972944277991686823219295939734313874834861796179591659174726432357533113896212781566659154939419866797488347448551719481632572231632463575591599696388223344219228325134233238538854289437756331848887242423387542214691157226725179683638967415678697625138177633444765126223885478348951332634398291612134852858683942466178329922655822225426534359191696177633167962839847985826676955417426617126288255366123169174674348417932158291334646767637764323226842771523598562429399935789788215958367362467652444854123951972118358417629679454978687337137675495295768451719631999398617828287671937584998697959425845883145736323818225129311845997214987663433375689621746665629187252511643969315283316269222835744532431378945137649959158495714472963839397214332815241141327714672141875129895";

        public static string GetResult(TaskNumber number)
        {
            switch(number)
            {
                case TaskNumber.First:
                    {
                        return GetResultFirst();
                    }
                case TaskNumber.Second:
                    {
                        return GetResultSecond();
                    }
            }
            return string.Empty;
        }

        private static string GetResultSecond()
        {
            var numbers = inputString.Select(x => Int32.Parse(x.ToString())).ToArray();
            var step = numbers.Count() / 2;
            var numberOfItems = numbers.Count();
            int sum = 0;
            for (int i=0; i<numberOfItems; i++)
            {
                sum += (i + step >= numberOfItems) ? 
                    (numbers[i] == numbers[(i+step)-numberOfItems] ? numbers[i] : 0) : ( numbers[i] == numbers[i+step] ? numbers[i] : 0);
            }
            return sum.ToString();
        }

        private static string GetResultFirst()
        {
            var numbers = inputString.Select(x => Int32.Parse(x.ToString()));
            int? currentNumber = null;
            int sum = 0;
            foreach(var number in numbers)
            {
                if(currentNumber.HasValue && currentNumber.Value == number)
                {
                    sum += number;
                }
                currentNumber = number;
            }
            if(numbers.First() == numbers.Last())
            {
                sum += numbers.First();
            }
            return sum.ToString();
        }

    }
}
