﻿using System;
using System.Linq;
using API.Models;

namespace API.Data
{
    public class DbInitialiser
    {

        public static void Initialise(MusicContext context)
        {
            Random random = new Random();
            Func<Random, Artist[], Artist> GetRandomArtist = (Random random, Artist[] artists) =>
            {
                int randNum = random.Next(0, artists.Length);
                return artists[randNum];
            };

            context.Database.EnsureCreated();

            if (context.Songs.Any())
            {
                return;
            }

            var artists = new Artist[]
            {
                new Artist{Name = "The Killers"},
                new Artist {Name = "The Strokes"},
                new Artist {Name = "Enter Shikari"}
            };
            
            foreach(var a in artists){
                context.Artists.Add(a);
            }


            context.SaveChanges();

            

            var songs = new Song[]
            {
                new Song{Name = "Marionettes", Lyrics = "Master\r\nI think you owe them an answer\r\nYou've become so complacent\r\nAnd they're becoming impatient\r\nVandal\r\nYou left their strings in a tangle\r\nSince you turned to the liquor\r\nTheir eyes are starting to flicker, oh\r\nThunder\r\nThey look up and they wonder\r\nAre they controlled by the heavens?\r\nThey start to question their essence, oh\r\nGet it together\r\nYou know there's only one minute\r\nOr they're gonna discover\r\nYou know there's only one minute\r\nGet it together\r\nYou know there's only one minute\r\nOr they're gonna discover\r\nThey're gonna uncover\r\nGet it together\r\nYou know there's only one minute\r\nOr they're gonna discover\r\nYou know there's only one minute\r\nGet it together\r\nYou know there's only one minute\r\nOr they're gonna discover\r\nThey're gonna uncover\r\nSober\r\nOh god I wish this was over\r\nAfter dark\u2026", 
                        CoverFilePath = "/resources/images/", Price = 5, ArtistId = GetRandomArtist(random, artists).Id},
                new Song{Name = "Selfless", Lyrics = "Can the dark side light my way? Oh, yeah, yeah\r\nLay your hand across my face, yeah, yeah\r\nTime we lost, that's all my fault\r\nPlease don't be long, 'cause I want your love\r\nI don't have love without your arm\r\nLife is too short, but I will live for you\r\nHow did this fit in your story? Yeah\r\nWhy'd you let them judge your body? Yeah\r\nI'll be waitin' there outside, yeah\r\nPlease don't be long, 'cause I want your arm\r\nI don't have fun without your love\r\nLife is too short, but I will live for you\r\nYou're mucking off, but I will live for you, my selfless love\r\nBite my tongue and wait my turn\r\nI waited for a century\r\nWaste my breath, no lessons learned\r\nI turn and face the enemy\r\nI'm not scared, just don't care\r\nI'm not listening, you hear?\r\nHe's never dead, but I don't care\r\nI can't tell you what and where\r\nYeah\r\nYeah", 
                        CoverFilePath = "/resources/images/", Price = 1, ArtistId = GetRandomArtist(random, artists).Id},
                new Song{Name = "Stop the Clocks", Lyrics = "Stop the clocks\r\nStop the clocks, I'm killing time\r\nI don't ever want this to end\r\nAnd you say \"That makes two of us\"\r\nThere's a cinema in me\r\nIt plays counterfeit scenes\r\nAll my worries and blunders\r\nAnd you say \"That makes two of us\"\r\nWhere's this present you speak of?\r\nWhere's this heavenly bliss?\r\nI'm so sick of time travel\r\nAnd you say \"That makes two of us\"\r\nAnd all your life, you just exist\r\nAnd all your life, it's moments missed\r\nAnd all the time, you wait in line\r\nWhat you'll find\r\nWell that makes two of us\r\nStop the clocks\r\nStop the clocks, I'm killing time\r\nI don't ever want this to end\r\nAnd you say \"That makes two of us\"\r\nStop the clocks\r\nStop the clocks, I'm killing time\r\nI don't ever want this to end\r\nAnd you say \"That makes two of us\"\r\nDrifting, my life is on hold now\r\nGive me coordinates please\r\nI look for a safe harbour\r\nAnd you say \"That makes two of us\"\r\nThere's a cinema in me\r\nIt plays counterfeit scenes\r\nAll my worries and blunders\r\nAnd you say \"That makes two of us\"\r\nAnd all your life, you just exist\r\nAnd all your life, it's moments missed\r\nAnd all the time, you wait in line\r\nWhat you'll find\r\nWell that makes two of us\r\nStop the clocks\r\nStop the clocks, I'm killing time\r\nI don't ever want this to end\r\nAnd you say \"That makes two of us\"\r\nStop the clocks\r\nStop the clocks, I'm killing time\r\nI don't ever want this to end\r\nAnd you say \"That makes two of us\"\r\nStop the clocks\r\nStop the clocks, I'm killing time\r\nI don't ever want this to end\r\nAnd you say \"That makes two of us\"\r\nStop the clocks\r\nStop the clocks, I'm killing time\r\nI don't ever want this to end\r\nAnd you say \"That makes two of us\"", 
                        CoverFilePath = "/resources/images/", Price = 1, ArtistId = GetRandomArtist(random, artists).Id},
                new Song{Name = "The adults are talking", Lyrics = "They've been sayin', \"You're sophisticated\"\r\nThey're complainin', overeducated\r\nYou are saying all the words I'm dreaming\r\nSay it after me\r\nSay it after me\r\nThey will blame us, crucify and shame us\r\nWe can't help it if we are a problem\r\nWe are tryin' hard to get your attention\r\nI'm climbin' up your wall\r\nClimbin' up your wall\r\nDon't go there 'cause you'll never return\r\nI know you think of me when you think of her\r\nBut then it don't make sense when you're tryin' hard\r\nTo do the right thing but without recompense\r\nAnd then you did something wrong and you said it was great\r\nAnd now you don't know how you could ever complain\r\nBecause you're all confused 'cause you want me to\r\nBut then you want me to do it the same as you\r\nYou were waitin' for the elevator\r\nYou were sayin' all the words I'm dreaming\r\nNo more askin' questions or excuses\r\nInformation's here\r\nHere and everywhere\r\nDon't go there 'cause you'll never return\r\nI know you think of me when you think of her\r\nBut then it don't make sense when you're tryin' hard\r\nTo do the right thing but without recompense\r\nAnd then you did something wrong and you said it was great\r\nAnd now you don't know how you could ever complain\r\nBecause you're all confused 'cause you want me to\r\nBut then you want me to do it the same way as you, and, but\r\nI don't, I don't want anything\r\nI know it's not, it's not your fault\r\nI don't want anyone\r\nAlways I do, it's not for you\r\nAh\r\nOoh\r\nStockholders\r\nSame shit, a different lie\r\nI'll get it right sometime\r\nOh, maybe not tonight\r\nOh, maybe not tonight\r\nOh, maybe not tonight\r\nOh, maybe not tonight\r\nOh, maybe not tonight\r\nHello?\r\nYeah, boy, here we go\r\nAnd a-one, and a-two, and a-three\r\nHere we go, friends\r\nHold on, I can't-\r\nMaybe that's kooky situation\r\nSo, let's go back to the old key, old tempo, everything\r\nOkay", 
                        CoverFilePath = "/resources/images/", Price = 1, ArtistId = GetRandomArtist(random, artists).Id},
                new Song{Name = "Super Massive Blackhole", Lyrics = "Oh baby, don't you know I suffer?\r\nOh baby, can you hear me moan?\r\nYou caught me under false pretenses\r\nHow long before you let me go?\r\nOoh\r\nYou set my soul alight\r\nYou set my soul alight\r\nGlaciers melting in the dead of night\r\nAnd the superstars sucked into the super massive (you set my soul alight)\r\nGlaciers melting in the dead of night\r\nAnd the superstars sucked into the super massive (you set my soul)\r\nI thought I was a fool for no one\r\nOh baby, I'm a fool for you\r\nYou're the queen of the superficial\r\nAnd how long before you tell the truth?\r\nYou set my soul alight\r\nYou set my soul alight\r\nGlaciers melting in the dead of night\r\nAnd the superstars sucked into the super massive (you set my soul alight)\r\nGlaciers melting in the dead of night\r\nAnd the superstars sucked into the super massive (you set my soul)\r\nSuper massive black hole\r\nSuper massive black hole\r\nSuper massive black hole\r\n(Super massive black hole)\r\nGlaciers melting in the dead of night\r\nAnd the superstars sucked into the super massive\r\nGlaciers melting in the dead of night\r\nAnd the superstars sucked into the super massive\r\nGlaciers melting in the dead of night\r\nAnd the superstars sucked into the super massive (you set my soul alight)\r\nGlaciers melting in the dead of night\r\nAnd the superstars sucked into the super massive (you set my soul)\r\nSuper massive black hole\r\nSuper massive black hole\r\nSuper massive black hole\r\n(Super massive black hole)", 
                        CoverFilePath = "/resources/images/", Price = 3, ArtistId = GetRandomArtist(random, artists).Id},
                new Song{Name = "Shinrin-Yoku", Lyrics = "Surrounded\r\nSunk deep in the dense embrace of the forest\r\nI imagine this is the polar opposite of suffocation\r\nMy lungs seem to gain extra capacity here\r\nAnd I feel like an empty inbox\r\nAs I, contemplate the ultimate assault course\r\nThe roots, the stumps, the branches\r\nI squint into eternity\r\nAs I try to get to grips with the fact that we have no idea what we're dealing with\r\nMy lungs will with air\r\nI feel supercharged now\r\nMy lungs will with air\r\nI feel supercharged\r\nMy lungs will with air\r\nI feel supercharged now\r\nMy lungs will with air\r\nI feel supercharged\r\nI'm hyper aware\r\nI shiver and short circuit\r\nAt the depths of the universe\r\nI'm hyper aware\r\nI shiver and short circuit\r\nAt the depths of the universe\r\nWe are the dust on the stained glass windows\r\nTrying to comprehend the cathedral\r\nWe are the dust on the stained glass windows\r\nTrying to comprehend the cathedral", 
                        CoverFilePath = "/resources/images/", Price = 2, ArtistId = GetRandomArtist(random, artists).Id},
                new Song{Name = "Pompeii", Lyrics = "Eh-eh-oh, eh-oh\r\nEh-eh-oh, eh-oh\r\nEh-eh-oh, eh-oh\r\nEh-eh-oh, eh-oh\r\nEh-eh-oh, eh-oh\r\nEh-eh-oh, eh-oh\r\nEh-eh-oh, eh-oh\r\nEh-eh-oh, eh-oh\r\nI was left to my own devices\r\nMany days fell away with nothing to show\r\nAnd the walls kept tumbling down\r\nIn the city that we love\r\nGrey clouds roll over the hills\r\nBringing darkness from above\r\nBut if you close your eyes\r\nDoes it almost feel like nothing changed at all?\r\nAnd if you close your eyes\r\nDoes it almost feel like you've been here before?\r\nHow am I gonna be an optimist about this?\r\nHow am I gonna be an optimist about this?\r\nWe were caught up and lost in all of our vices\r\nIn your pose as the dust settled around us\r\nAnd the walls kept tumbling down\r\nIn the city that we love\r\nGrey clouds roll over the hills\r\nBringing darkness from above\r\nBut if you close your eyes\r\nDoes it almost feel like nothing changed at all?\r\nAnd if you close your eyes\r\nDoes it almost feel like you've been here before?\r\nHow am I gonna be an optimist about this?\r\nHow am I gonna be an optimist about this?\r\nEh-oh, eh-oh\r\nEh-eh-oh, eh-oh\r\nEh-eh-oh, eh-oh\r\nEh-eh-oh, eh-oh\r\nOh, where do we begin?\r\nThe rubble or our sins?\r\nOh, oh, where do we begin?\r\nThe rubble or our sins?\r\nAnd the walls kept tumbling down\r\nIn the city that we love\r\nGrey clouds roll over the hills\r\nBringing darkness from above\r\nBut if you close your eyes\r\nDoes it almost feel like nothing changed at all?\r\nAnd if you close your eyes\r\nDoes it almost feel like you've been here before?\r\nHow am I gonna be an optimist about this?\r\nHow am I gonna be an optimist about this?\r\nIf you close your eyes\r\nDoes it almost feel like nothing changed at all?\r\nEh-eh-oh, eh-oh\r\nEh-eh-oh, eh-oh\r\nEh-eh-oh, eh-oh\r\nEh-eh-oh, eh-oh\r\nEh-eh-oh, eh-oh\r\nEh-eh-oh, eh-oh\r\nEh-eh-oh, eh-oh\r\nEh-eh-oh, eh-oh", 
                        CoverFilePath = "/resources/images/", Price = 2, ArtistId = GetRandomArtist(random, artists).Id},
                new Song{Name = "The Sights", Lyrics = "Are you staying awake for the liftoff, tonight?\r\nYou'll never believe the sights tonight\r\nThe sights tonight, the sights\r\nAre you staying awake for the liftoff, tonight?\r\nYou'll never believe the sights tonight\r\nThe sights tonight\r\nMr. Magpie\r\nYou got distracted by the gleam of the diamonds, as you flew by\r\nBut their dull glimpse does not impress\r\nWhen there's a billion stars in the sky\r\nI see you gripping my pen like a bread-knife\r\nAs I write, I'm leaving this earth for the stars tonight\r\nAnd now I'm running to board the flight\r\nNow above we go\r\nInto the great unknown\r\nI like Jacques Cousteau\r\nI give you my mind to be blown\r\nNow above we go\r\nInto the great unknown\r\nLike Marcus Cicero\r\nWell this life is whole\r\nI'm searching far and wide to find a planet to orbit\r\nFar and wide, I wanna scan it and explore it\r\nFar and wide, you're my new planet to orbit\r\nSo fire up the rockets\r\nAre you staying awake for the liftoff, tonight?\r\nYou'll never believe the sights tonight\r\nThe sights tonight, the sights\r\nAre you staying awake for the liftoff, tonight?\r\nYou'll never believe the sights tonight\r\nThe sights tonight, the sights\r\nNow above we go\r\nInto the great unknown\r\nI like Jacques Cousteau\r\nI give you my mind to be blown\r\nNow above we go\r\nInto the great unknown\r\nLike Marcus Cicero\r\nWell this life is whole\r\nI'm searching far and wide to find a planet to orbit\r\nFar and wide, I wanna scan it and explore it\r\nFar and wide, you're my new planet to orbit\r\nSo fire up the rockets\r\nIt's over now and I'm a little bit petrified\r\nOf what's to come, yeah my head's a bit stir-fried\r\nIt's over now and I'm a little unqualified\r\nBut fire up the rockets\r\nfar and wide to find a planet to orbit\r\nFar and wide, I wanna scan it and explore it\r\nFar and wide, you're my new planet to orbit\r\nSo fire up the rockets", 
                        CoverFilePath = "/resources/images/", Price = 5, ArtistId = GetRandomArtist(random, artists).Id},
                new Song{Name = "When you were young", Lyrics = "You sit there in your heartache\r\nWaiting on some beautiful boy to\r\nTo save you from your old ways\r\nYou play forgiveness\r\nWatch it now, here he comes\r\nHe doesn't look a thing like Jesus\r\nBut he talks like a gentlemen\r\nLike you imagined when you were young\r\nCan we climb this mountain?\r\nI don't know\r\nHigher now than ever before\r\nI know we can make it if we take it slow\r\nLet's take it easy\r\nEasy now, watch it go\r\nWe're burning down the highway skyline\r\nOn the back of a hurricane that started turning\r\nWhen you were young\r\nWhen you were young\r\nAnd sometimes you close your eyes\r\nAnd see the place where you used to live\r\nWhen you were young\r\nThey say the devil's water, it ain't so sweet\r\nYou don't have to drink right now\r\nBut you can dip your feet\r\nEvery once in a little while\r\nYou sit there in your heartache\r\nWaiting on some beautiful boy to\r\nTo save you from your old ways\r\nYou play forgiveness\r\nWatch it now, here he comes\r\nHe doesn't look a thing like Jesus\r\nBut he talks like a gentlemen\r\nLike you imagined when you were young\r\n(Talks like a gentlemen, like you imagined)\r\nWhen you were young\r\nI said he doesn't look a thing like Jesus\r\nHe doesn't look a thing like Jesus\r\nBut more than you'll ever know", 
                        CoverFilePath = "/resources/images/", Price = 2.5m, ArtistId = GetRandomArtist(random, artists).Id}
            };

            foreach (var s in songs)
            {
                context.Songs.Add(s);
            }

            context.SaveChanges();
        }
    }
}
