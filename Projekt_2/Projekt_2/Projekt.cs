﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_2
{
    class Projekt
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\t\t██████╗░██████╗░░█████╗░░░░░░██╗███████╗██╗░░██╗████████╗\n\t\t██╔══██╗██╔══██╗██╔══██╗░░░░░██║██╔════╝██║░██╔╝╚══██╔══╝\n\t\t██████╔╝██████╔╝██║░░██║░░░░░██║█████╗░░█████═╝░░░░██║░░░\n\t\t██╔═══╝░██╔══██╗██║░░██║██╗░░██║██╔══╝░░██╔═██╗░░░░██║░░░\n\t\t██║░░░░░██║░░██║╚█████╔╝╚█████╔╝███████╗██║░╚██╗░░░██║░░░\n\t\t╚═╝░░░░░╚═╝░░╚═╝░╚════╝░░╚════╝░╚══════╝╚═╝░░╚═╝░░░╚═╝░░░");
            string mit = "0";
            string akarsz = "i";
            while (akarsz == "i")
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\n\n\nMit szertnél játszani?\n");
                Console.ForegroundColor = ConsoleColor.White;
                do
                {
                    Console.Write("1: Bűnügyi nyomozás\n2: Macska szimulátor\n");
                    Console.WriteLine();
                    mit = Console.ReadLine();
                } while (mit != "1" && mit != "2");
                if (mit == "1")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t\t\t\t\t - ! - Bűnügyi nyomozás - ! -\n\t");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" - ! - Egy fő háttértörtének és az abban szereplő emberek elmondásai alapján kell megfejtened egy bűnügyi esetet! - ! - \n - !- Jól gondold át a válaszodat a döntésed, hiszen csak egy lehetőséged van elkapni az elkövetőt! - ! - \n\nEgy szombat hajnali egy óra felé egy férfit a hálószobájában találnak holtan, mellkason szúrva. A házban a felesége, a kertész és egy szakács tartózkodott az eset ideje alatt. A feleség hívta ki a rendőrséget szombaton, reggel, fél tizenegy órakor. A nyomozó, nem mondott el senkinek semmi részletet vagy körülményt a gyilkossággal kapcsolatban, azonnal a potenciális elkövetők alibijére volt kíváncsi:\n\tFeleség: Állítása szerint a férjét az előző esti vacsoránál látta utoljára, ami után átment a lányukhoz és ott aludt, aki két utcával odébb lakott, de a férje nem tartott vele, mert már nagyon fáradt volt. A kertésszel találkozott indulás előtt, éppen a sövényt nyírta formára. Este fél tizenkettő után három perccel még felhívta a szakácsot, hogy szóljon neki arról hogy késik a reggeliről. Ezért ért haza fél tizenegy órakor, amikor is rátalált a férje holt testére.\n\tA feleség alibijét hallva a nyomozó felvette az özvegy lányának a vallomását is. \n\tA lány biztosan állította, hogy az anyja előző éjszakán náluk aludt. Beszámolt arról is, hogy mielőtt az anyja odaért volna, felhívta az apját aki elmondta neki, hogy fáradtsága miatt inkább otthon marad. A lány sajnálta, de nem erősködött, mert tudta, hogy apja akkoriban sokat gyengélkedett. Másnap az anyja hívta fel dél előtt tíz perccel, hogy elmondja neki a halálhírt.\n\tKerész: Állítása szerint este lenyírta a sövényt, miközben találkozott a feleséggel, aki egyedül hagyta el a ház területét, de utána nem látta aznap, csak másnap mikor dolgozni indult és akkorra már a feleség a rendőrséggel együtt fogadta. Még este bepakolt a fészerbe és indulása előtt lement a konyhába, ez éjfélkor történt, senki nem volt a konyhában a csap tele volt a elmosatlan edényekkel, látszólag minden rendben volt, egy valamit kivéve egy fiókot. A fiók ki volt húzva, hiányzott belőle egy kés, ami azért volt feltűnő hiszen a tokja üresen hevert. Kifelé menet látta a szakácsot a nappaliban nézte a tv-t, elköszönt tőle, de a szakács csak ránézett és nevetett. A kertész szerint a szakács gyakran viselkedett furcsán, de azt gondolta biztos ivott megint valamit. \n\tSzakács: Állítása szerint a vacsora után elmosogatott, és mivel már nem volt dolga éjfélkor hazament, nem találkozott senkivel, másnap akkor ért a házhoz mikor a feleség felhívta azzal, hogy a nyomozó beszélni szeretne vele. Első reakciója az volt, hogy rákérdezzen arra, hogy megtalálták-e azt a kést amivel a gyilkosságot elkövették.");
                    string kiaz = "0";
                    do
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("Ki lehetett a gyilkos? \n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("1: A feleség\n2: A szakács\n3: A kertész\n");
                        kiaz = Console.ReadLine();
                    } while (kiaz != "1" && kiaz != "2" && kiaz != "3");
                    if (kiaz == "2")
                    {
                        Console.WriteLine("Eltaláltad a helyes választ!");
                        Console.WriteLine("A gyilkos a szakács volt. Ez abból állapítható meg, hogy nem említette, hogy a feleség felhívta volna, illetve azt állította, hogy nem találkozott senkivel, pedig a kertész állította, hogy látta a nappaliban tv-t nézni. A kertész alibijét pedig alátámasztotta a feleség, akit a saját lánya igazolt. Azt állította, hogy elmosogatott, pedig az edények mosatlanul álltak a konyhában. A legszembetűnőbb az, hogy a nyomozó nem mondta el, hogy a bűncselekményt egy késsel követték el, de a szakács egyből a késről érdeklődött.");
                    }
                    else
                    {
                        Console.WriteLine("A válasz helytelen!");
                        Console.WriteLine("A gyilkos a szakács volt. Ez abból állapítható meg, hogy nem említette, hogy a feleség felhívta volna, illetve azt állította, hogy nem találkozott senkivel, pedig a kertész állította, hogy látta a nappaliban tv-t nézni. A kertész alibijét pedig alátámasztotta a feleség, akit a saját lánya igazolt. Azt állította, hogy elmosogatott, pedig az edények mosatlanul álltak a konyhában. A legszembetűnőbb az, hogy a nyomozó nem mondta el, hogy a bűncselekményt egy késsel követték el, de a szakács egyből a késről érdeklődött.");
                    }


                }
                if (mit == "2")
                {
                    int meghalsz = 0;
                    string igen = "";
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\t\t\t\t\t - ! - Macska szimulátor - ! -\n\t");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine(" - ! - A játék lényege az, hogy te egy macska szerepében tudd minél tovább túlélni.\n\tA játék folyamán a döntésed befolyásolják majd a végkifejletet. \n\tHa választási lehetőség elé kerülsz az általad választott cselekvés számának megadásával tudod végrehajtani azt.- ! -\n        _..---...,''-._     ,/}/)\t--Igaz történet alapján--\n     .''        ,      ``..'(/-< \n    /   _      {      )         |\n   ;   _ `.     `.   <         a(\n ,'   ( |  )      `.  | __.._ .: y\n(  <|_-) )'-.____...|  `._   //-'\n `. `-' /-._)))      `-._)))\n   `...'     \n");
                    
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n- + - 1. nap - + -");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("A gazdáid hazavittek magukkal egy új kutyát. Így már nem vagy egyedüli háziállat. A kutya csak néhány hónapos, te meg már egy éves múltál, ami azt jeleni hogy előnyösek számodra az erőviszonyok. Az első találkozásotok alkalmával...");
                    Console.WriteLine("1: Megtámadod, ezzel bosszút állva azért mert úgy érzed hogy lecserélnek. \n2: Nem foglalkozol vele, ameddig ő is békén hagy téged nem érdekel.\n3: Elfutsz, mert félsz az ismeretlen állattól. \n\t");
                    igen = "";
                    do
                    {
                        igen = Console.ReadLine();
                    } while (igen != "1" && igen != "2" && igen != "3");
                    switch (igen)
                    {
                        case "1": meghalsz++; break;
                        case "2": break;
                        default: break;
                    }
                    
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n- + - 2. nap - + -");
                    Console.ForegroundColor = ConsoleColor.White;
                    if (meghalsz == 1)
                    {
                        Console.WriteLine("Az előző napi incidensed után a gazdáid megharagudtak rád, és az ellenkezőjét érted el annak amit szerettél volna. Este, a szokásos etetési időben kevesebb ételt adtak, azt remélve, hogy a két cselekményt majd összekötöd.\nAznap amikor elmentek dolgozni a kutyát nem láttad sehol, látszólag egyedül voltál a lakásban, egy valami viszont eltért a megszokottól. Az asztalon kint felejtettek egy zacskó kiflit...");
                        Console.WriteLine("1: Felugrasz az asztalra és beleeszel az egyik kiflibe\n2: Felugrasz az asztalra és a bosszútól fűtve beleeszel mindegyikbe\n3: Figyelmen kívül hagyod, mivel nem szeretnél még több bajt\n\t");
                        igen = "";
                        do
                        {
                            igen = Console.ReadLine();
                        } while (igen != "1" && igen != "2" && igen != "3");
                        switch (igen)
                        {
                            case "1": meghalsz++; break;
                            case "2": meghalsz = meghalsz + 2; break;
                            default: break;
                        }
                        if (meghalsz == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n- + - 3. nap - + -");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Reggel szokásuk szerint a gazdáid elmentek dolgozni. Körül nézel a lakásban sehol semmi. Felugrasz az asztalra, de érzed, hogy valamibe beleragadt a lábad. Gyorsan leugrasz, ragasztó... próbálkoznak... Ezek után kimész a nappaliba, felugrasz a kanapéra, ahonnan látod a kutyát. Békésen aludt a szőnyegen. Ennél sokkal érdekesebbnek tűnik a nappali új függönye. Hosszú, sötét kék, szinte a földig ért. Úgy gondolod, hogy...");
                            Console.WriteLine("1: Felmászol a függönyre, ami a karmain nyomán végigszakad\n2: Bosszúból rátámadsz a kutyára, hiszen nem őt tartod az elhanyagolásod okának és nem az elviselhetetlen viselkedésedet");
                            igen = "";
                            do
                            {
                                igen = Console.ReadLine();
                            } while (igen != "1" && igen != "2");
                            switch (igen)
                            {
                                case "2": meghalsz += 3; break;
                                case "1": meghalsz += 2; break;
                                default: break;
                            }
                            if (meghalsz == 5)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\n- + - 4. nap - + -");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("A gazdáid úgy gondolják, hogy mivel veszélyt jelentesz új házikedvencükre, ez megrémíti őket. Elkezdenek félni tőled. Vajon ha megtámadtad a kutyát mi választ el attól, hogy majd a gyerekeket is?\nÚgy döntenek, hogy be visznek egy menhelyre. Te nem akarsz ott lenni hiányzik az otthon, hiányoznak az ismerősök, hiányoznak az ismerős emberek, az ismerős helyek, az ismerős tárgyak, a biztonságos közeg. Reccsen egy zár, törik egy ajtó egy hatalmas fehér keverék kutya fut feléd.\nVége\nA kutya állkapcsai összecsattannak, a gond az, hogy te a fogai közt vagy. Egy hatalmas reccsenést hallasz... a saját bordáid... többet már nem hallod a reccsenést... de többé már mást sem.");
                                Console.WriteLine("╔═══╗─────────╔═══╗\n║╔═╗║─────────║╔═╗║\n║║─╚╬══╦╗╔╦══╗║║─║╠╗╔╦══╦═╗\n║║╔═╣╔╗║╚╝║║═╣║║─║║╚╝║║═╣╔╝\n║╚╩═║╔╗║║║║║═╣║╚═╝╠╗╔╣║═╣║\n╚═══╩╝╚╩╩╩╩══╝╚═══╝╚╝╚══╩╝\n");  
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\t - ! - A játék során egy macskának sem esett bántódása! - ! -\n\t"); 
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            if (meghalsz == 4)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\n- + - 4. nap - + -");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("A gazdáid hazaérnek, meglátják azt, hogy mi történt a frissen vásárolt függönnyel. Már alig bírják megállni, hogy ne tegyenek kóbor macskává, de él még bennük a remény irántad. Lecserélik az összes függönyt, elpakolnak a polcokról.\nReggel szokásosan megetetnek, és elmennek dolgozni. Kisétálsz a nappaliba éppen sikerül felugranod a polcra ahogyan meglátod hogy a kutya feléd közeledik. Úgy döntesz, hogy elmész aludni, azzal legalább elmegy az idő.");
                                Console.WriteLine(" Aludtál három órán keresztül, arra ébredsz, hogy éhes vagy. Körül nézel feltérképezed a környeztet, lemászol a szekrényről, és ahogy a táladhoz érsz, azt veszed észre, hogy üres, és a kutya ott alszik mellette.\nVisszamész a nappaliba, látod, hogy szemben a polcon van egy zacskó kutya kaja... ");
                                Console.WriteLine("1: Visszafekszel aludni, és majd eszel amikor a gazdáid hazajönnek és megetetnek\n2: Felugrasz a szekrényre és bosszúból beleeszel a kutya kajájába\n\t");

                                igen = "";
                                do
                                {
                                    igen = Console.ReadLine();
                                } while (igen != "1" && igen != "2");
                                switch (igen)
                                {
                                    case "1": break;
                                    case "2": meghalsz++; break;
                                    default: break;
                                }
                                if (meghalsz == 4)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n- + - 5. nap - + -");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("A gazdáid kénytelenek feltakarítani utánad, dühből kiraknak az ajtó elé. Felugrasz az ablakpárkányra. Látod őket egymással veszekedve, de te nem velük törődsz csak arra tudsz figyelni, hogy fázol.");
                                    Console.WriteLine("1: Az ablakban ülve várod, hogy beengedjenek\n2: Elkezded kaparni az ablakkeretet, hogy beengedjenek végre\n\t");
                                    igen = "";
                                    do
                                    {
                                        igen = Console.ReadLine();
                                    } while (igen != "1" && igen != "2");
                                    switch (igen)
                                    {
                                        case "1": meghalsz++; break;
                                        case "2": meghalsz += 2; break;
                                        default: break;
                                    }
                                    if (meghalsz == 6)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\n- + - 6. nap - + -");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Kint vártál egy órát amíg végül beengedtek, megetted a vacsorádat és elmentél aludni.\nReggel a gazdáid szokásukhoz híven elmentek dolgozni, miután megetettek. Visszafekszel még aludni egészen délután négyig, mikor is megint megéhezel. Látod hogy van még kajád a tálban, de van az asztalon egy darálthúsos palacsinta.");
                                        Console.WriteLine("1: Megeszed a saját kajádat\n2: Engedsz a kísértésnek és megeszed a palacsintát\n\t");
                                        igen = "";
                                        do
                                        {
                                            igen = Console.ReadLine();
                                        } while (igen != "1" && igen != "2");
                                        switch (igen)
                                        {
                                            case "1": break;
                                            case "2": meghalsz++; break;
                                            default: break;
                                        }
                                        if (meghalsz == 6)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("\n- + - 7. nap - + -");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("A gazdáid hazaérnek még őket is meglepi, hogy nem csináltál semmi rosszat.\nEgy vasárnapi nap volt, a gazdáid otthon voltak egész nap. Próbáltál közel kerülni hozzájuk, de ők kerültek téged. A gyerekek kint fürdenek a medencében. Fel akarod hívni magadra a figyelmet azzal, hogy...");
                                            Console.WriteLine("1: Beugrasz a medencébe\n2: Kikarmolod a medencét\n\t");
                                            igen = "";
                                            do
                                            {
                                                igen = Console.ReadLine();
                                            } while (igen != "1" && igen != "2");
                                            switch (igen)
                                            {
                                                case "1": break;
                                                case "2": meghalsz++; break;
                                                default:
                                                    break;
                                            }
                                            if (meghalsz == 7)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("\n- + - 8. nap - + -");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.WriteLine("Kapálózol a vízben. Lehet rosszkor, de most jössz rá, hogy nem tudsz úszni. Egyszer csak elmerülsz, hallod a gyerek hangját, ahogy hívják a szüleiket. Nem mernek neked segíteni, de a szülök nem érnek oda időben.\nVége\nEgyre halkabban hallod a gyerekek hangját, míg végül teljesen eltompul... Többen nem hallasz semmit.");
                                                Console.WriteLine("╔═══╗─────────╔═══╗\n║╔═╗║─────────║╔═╗║\n║║─╚╬══╦╗╔╦══╗║║─║╠╗╔╦══╦═╗\n║║╔═╣╔╗║╚╝║║═╣║║─║║╚╝║║═╣╔╝\n║╚╩═║╔╗║║║║║═╣║╚═╝╠╗╔╣║═╣║\n╚═══╩╝╚╩╩╩╩══╝╚═══╝╚╝╚══╩╝\n");
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("\t - ! - A játék során egy macskának sem esett bántódása! - ! -\n\t");
                                                Console.ForegroundColor = ConsoleColor.White;
                                            }
                                            if (meghalsz == 8)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("\n- + - 8. nap - + -");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.WriteLine("Belekapsz a medencébe, a karmod beleakad, nem tudod elengedni, magadra rántod az egész medencét.\nVége.\n Rádtekeredik, egyre szorosabb, egyre erősebb, egyre kevesebb levegő jut be, egyre kevesebb a fény, egyre kevesebb hangot hallasz, egyre kevésbé érzel... Levegőért kapsz ahogyan a mellkasod behúzódik a medence fala jobban rád szorul... többet már nem húzódik be.");
                                                Console.WriteLine("╔═══╗─────────╔═══╗\n║╔═╗║─────────║╔═╗║\n║║─╚╬══╦╗╔╦══╗║║─║╠╗╔╦══╦═╗\n║║╔═╣╔╗║╚╝║║═╣║║─║║╚╝║║═╣╔╝\n║╚╩═║╔╗║║║║║═╣║╚═╝╠╗╔╣║═╣║\n╚═══╩╝╚╩╩╩╩══╝╚═══╝╚╝╚══╩╝\n");
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("\t - ! - A játék során egy macskának sem esett bántódása! - ! -\n\t");
                                                Console.ForegroundColor = ConsoleColor.White;
                                            }
                                        }
                                        if (meghalsz == 8)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("\n- + - 7. nap - + -");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("Beleeszel a palacsintába, szokatlan íze van, de nem törődsz vele. Egyszer csak valami hasító fájdalmat érzel, hátrébb lépsz és ránézel az ételre. Látsz benne egy kis sárga kockát, lehet hogy az okozta a furcsa ízt?\nVége.\nPatkány méreg... hirtelen a fájdalmaid közepette levegőt sem kapsz. Ugrasz egyet hátra, amivel lelökőd az egyik poharat... de többé nem löksz le semmit.");
                                            Console.WriteLine("╔═══╗─────────╔═══╗\n║╔═╗║─────────║╔═╗║\n║║─╚╬══╦╗╔╦══╗║║─║╠╗╔╦══╦═╗\n║║╔═╣╔╗║╚╝║║═╣║║─║║╚╝║║═╣╔╝\n║╚╩═║╔╗║║║║║═╣║╚═╝╠╗╔╣║═╣║\n╚═══╩╝╚╩╩╩╩══╝╚═══╝╚╝╚══╩╝\n");
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("\t - ! - A játék során egy macskának sem esett bántódása! - ! -\n\t");
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }
                                    }
                                    if (meghalsz == 6)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\n- + - 6. nap - + -");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("A gazdáid végleg megelégeltek.\n Kinyitják az ablakot, nem tudsz időben elugrani látod, hogy a gazdád emeli a kezét, erősen megütött mire te hátraesel, egészen bele az ablak alatt lévő kerítés drótjába.\nVége.\nÉrzed, ahogyan egy nagy fémdarab átfúródik a testeden. Egy meleg érzés önt el. Vér. Érzed, hogy tovább zuhansz... de hirtelen már nem érzed... de többé mást sem.");
                                        Console.WriteLine("╔═══╗─────────╔═══╗\n║╔═╗║─────────║╔═╗║\n║║─╚╬══╦╗╔╦══╗║║─║╠╗╔╦══╦═╗\n║║╔═╣╔╗║╚╝║║═╣║║─║║╚╝║║═╣╔╝\n║╚╩═║╔╗║║║║║═╣║╚═╝╠╗╔╣║═╣║\n╚═══╩╝╚╩╩╩╩══╝╚═══╝╚╝╚══╩╝\n");
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\t - ! - A játék során egy macskának sem esett bántódása! - ! -\n\t");
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                }
                                if (meghalsz == 6)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n- + - 5. nap - + -");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("A gazdáid kénytelenek feltakarítani utánad, dühből kiraknak az ajtó elé. Meglátod, hogy egy nagy fekete rottweiler. Leblokkolsz, de még a reflexeid képesek annyira, hogy futni kezdj, egy kis utcába kanyarodsz, mivel ritkán jársz kint így nem tudtad, hogy az ott egy zsákutca. Pedig az volt. Sarokba vagy szorítva, nem tudsz átmászni. Látod hogy a kutya feléd fut, és '...\nVége.\nA rottweiler állkapcsai összecsattannak, a gond az, hogy te a fogai közt vagy. Egy hatalmas reccsenést hallasz... a saját bordáid... többet már nem hallod a reccsenést... de többé már mást sem.");
                                    Console.WriteLine("╔═══╗─────────╔═══╗\n║╔═╗║─────────║╔═╗║\n║║─╚╬══╦╗╔╦══╗║║─║╠╗╔╦══╦═╗\n║║╔═╣╔╗║╚╝║║═╣║║─║║╚╝║║═╣╔╝\n║╚╩═║╔╗║║║║║═╣║╚═╝╠╗╔╣║═╣║\n╚═══╩╝╚╩╩╩╩══╝╚═══╝╚╝╚══╩╝\n");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\t - ! - A játék során egy macskának sem esett bántódása! - ! -\n\t");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                            }
                        }
                        if (meghalsz == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n- + - 3. nap - + -");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Gazdáid egyre mérgesebbek, de próbálják türtőztetni magukat. Továbbra sem sikerült elérned azt amit szeretnél.\nReggel szokásuk szerint a gazdáid elmentek dolgozni. Körül nézel a lakásban sehol semmi. Felugrasz az asztalra, de érzed, hogy valamibe beleragad a lábad. Gyorsan leugrasz, ragasztó... próbálkoznak... Ezek után kimész a nappaliba, felugrasz a kanapéra, ahonnan látod a kutyát. Békésen aludt a szőnyegen. Ennél sokkal érdekesebbnek tűnik a nappali új függönye. Hosszú, sötétkék, szinte a földig ért. Úgy gondolod, hogy...");
                            Console.WriteLine("1: Felmászol a függönyre, ami a karmain nyomán végigszakad\n2: Bosszúból rátámadsz a kutyára, hiszen őt tartod az elhanyagolásod okának és nem az elviselhetetlen viselkedésedet");
                            igen = "";
                            do
                            {
                                igen = Console.ReadLine();
                            } while (igen != "1" && igen != "2");
                            switch (igen)
                            {
                                case "2": meghalsz += 3; break;
                                case "1": meghalsz += 2; break;
                                default: break;
                            }
                            if (meghalsz == 5)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\n- + - 4. nap - + -");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("A gazdáid úgy gondolják, hogy mivel veszélyt jelentesz újházikedvecükre,ezmegrémítíőket.ElkezdenekfélnitőledVajohamegtámadtad a kutyát mi választ el attól, hogy majd a gyerekeket \nÚgy döntenek, hogy bevisznek egy menhelyre. Te nem akarsz ott lenni hiányzik az otthon, hiányoznak az ismerősök, hiányoznak az ismerős emberek a ismerőshelyek, az ismerő tárgyak, biztonságos közeg. Reccsen egy zár, törik egy ajtó egy hatalmas fehér keverék kutya fut feléd\nVége.\nA kutya állkapcsai összecsattannak, a gond az, hogy te a fogai közt vagy. Egy hatalmas reccsenést hallasz... a saját bordáid... többet már nemhallod a reccsenést... de többé már mást sem.");
                                Console.WriteLine("╔═══╗─────────╔═══╗\n║╔═╗║─────────║╔═╗║\n║║─╚╬══╦╗╔╦══╗║║─║╠╗╔╦══╦═╗\n║║╔═╣╔╗║╚╝║║═╣║║─║║╚╝║║═╣╔╝\n║╚╩═║╔╗║║║║║═╣║╚═╝╠╗╔╣║═╣║\n╚═══╩╝╚╩╩╩╩══╝╚═══╝╚╝╚══╩╝\n");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\t - ! - A játék során egy macskának sem esett bántódása! - ! -\n\t");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            if (meghalsz == 4)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\n- + - 4. nap - + -");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("A gazdáid hazaérnek, meglátják azt, hogy mi történt a frissen vásárolt függönnyel. Már alig bírják megállni, hogy ne tegyenek kóbor macskává, de él még bennük a remény irántad. Lecserélik az összes függönyt, elpakolnak a polcokról.\nReggel szokásosan megetetnek, és elmennek dolgozni. Kisétálsz a nappaliba éppen sikerül felugranod a polcra ahogyan meglátod hogy a kutya feléd közeledik. Úgy döntesz, hogy elmész aludni, azzal legalább elmegy az idő.");
                                Console.WriteLine(" Aludtál három órán keresztül, arra ébredsz, hogy éhes vagy. Körül nézel feltérképezed a környeztet, lemászol a szekrényről, és ahogy a táladhoz érsz, azt veszed észre, hogy üres, és a kutya ott alszik mellette.\nVisszamész a nappaliba, látod, hogy szemben a polcon van egy zacskó kutya kaja... ");
                                Console.WriteLine("1: Visszafekszel aludni, és majd eszel amikor a gazdáid hazajönnek és megetetnek\n2: Felugrasz a szekrényre és bosszúból beleeszel a kutya kajájába\n\t");
                                igen = "";
                                do
                                {
                                    igen = Console.ReadLine();
                                } while (igen != "1" && igen != "2");
                                switch (igen)
                                {
                                    case "1": break;
                                    case "2": meghalsz++; break;
                                    default: break;
                                }
                                if (meghalsz == 4)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n- + - 5. nap - + -");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("A gazdáid kénytelenek feltakarítani utánad, dühből kiraknak az ajtó elé. Felugrasz az ablakpárkányra. Látod őket egymással veszekedve, de te nem velük törődsz csak arra tudsz figyelni, hogy fázol.");
                                    Console.WriteLine("1: Az ablakban ülve várod, hogy beengedjenek\n2: Elkezded kaparni az ablakkeretet, hogy beengedjenek végre\n\t");
                                    igen = "";
                                    do
                                    {
                                        igen = Console.ReadLine();
                                    } while (igen != "1" && igen != "2");
                                    switch (igen)
                                    {
                                        case "1": meghalsz++; break;
                                        case "2": meghalsz += 2; break;
                                        default: break;
                                    }
                                    if (meghalsz == 6)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\n- + - 6. nap - + -");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("A gazdáid végleg megelégeltek.\n Kinyitják az ablakot, nem tudsz időben elugrani látod, hogy a gazdád emeli a kezét, erősen megütött mire te hátraesel, egészen bele az ablak alatt lévő kerítés drótjába.\nVége.\nÉrzed, ahogyan egy nagy fémdarab átfúródik a testeden. Egy meleg érzés önt el. Vér. Érzed, hogy tovább zuhansz... de hirtelen már nem érzed... de többé mást sem.");
                                        Console.WriteLine("╔═══╗─────────╔═══╗\n║╔═╗║─────────║╔═╗║\n║║─╚╬══╦╗╔╦══╗║║─║╠╗╔╦══╦═╗\n║║╔═╣╔╗║╚╝║║═╣║║─║║╚╝║║═╣╔╝\n║╚╩═║╔╗║║║║║═╣║╚═╝╠╗╔╣║═╣║\n╚═══╩╝╚╩╩╩╩══╝╚═══╝╚╝╚══╩╝\n");
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\t - ! - A játék során egy macskának sem esett bántódása! - ! -\n\t");
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                    if (meghalsz == 5)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\n- + - 6. nap - + -");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Kint vártál egy órát amíg végül beengedtek, megetted a vacsorádat és elmentél aludni.\nReggel a gazdáid szokásukhoz híven elmentek dolgozni, miután megetettek. Visszafekszel még aludni egészen délután négyig, mikor is megint megéhezel. Látod hogy van még kajád a tálban, de van az asztalon egy darálthúsos palacsinta.");
                                        Console.WriteLine("1: Megeszed a saját kajádat\n2: Engedsz a kísértésnek és megeszed a palacsintát\n\t");
                                        igen = "";
                                        do
                                        {
                                            igen = Console.ReadLine();
                                        } while (igen != "1" && igen != "2");
                                        switch (igen)
                                        {
                                            case "1": break;
                                            case "2": meghalsz++; break;
                                            default: break;
                                        }
                                        if (meghalsz == 4)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("\n- + - 7. nap - + -");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("A gazdáid hazaérnek még őket is meglepi, hogy nem csináltál semmi rosszat.\nEgy vasárnapi nap volt, a gazdáid otthon voltak egész nap. Próbáltál közel kerülni hozzájuk, de ők kerültek téged. A gyerekek kint fürdenek a medencében. Fel akarod hívni magadra a figyelmet azzal, hogy...");
                                            Console.WriteLine("1: Beugrasz a medencébe\n2: Kikarmolod a medencét\n\t");
                                            igen = "";
                                            do
                                            {
                                                igen = Console.ReadLine();
                                            } while (igen != "1" && igen != "2");
                                            switch (igen)
                                            {
                                                case "1": break;
                                                default: meghalsz++; break;
                                            }

                                            if (meghalsz == 5)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("\n- + - 8. nap - + -");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.WriteLine("Kapálózol a vízben. Lehet rosszkor, de most jössz rá, hogy nem tudsz úszni. Egyszer csak elmerülsz, hallod a gyerek hangját, ahogy hívják a szüleiket. Nem mernek neked segíteni, de a szülök nem érnek oda időben.\nVége.\nEgyre halkabban hallod a gyerekek hangját, míg végül teljesen eltompul... Többen nem hallasz semmit.");
                                                Console.WriteLine("╔═══╗─────────╔═══╗\n║╔═╗║─────────║╔═╗║\n║║─╚╬══╦╗╔╦══╗║║─║╠╗╔╦══╦═╗\n║║╔═╣╔╗║╚╝║║═╣║║─║║╚╝║║═╣╔╝\n║╚╩═║╔╗║║║║║═╣║╚═╝╠╗╔╣║═╣║\n╚═══╩╝╚╩╩╩╩══╝╚═══╝╚╝╚══╩╝\n");
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("\t - ! - A játék során egy macskának sem esett bántódása! - ! -\n\t");
                                                Console.ForegroundColor = ConsoleColor.White;
                                            }
                                            if (meghalsz == 6)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("\n- + - 8. nap - + -");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.WriteLine("Belekapsz a medencébe, a karmod beleakad, nem tudod elengedni, magadra rántod az egész medencét.\nVége.\n Rádtkeredik, egyre szorosabb, egyre erősebb, egyre kevesebb levegő jut be, egyre kevesebb a fény, egyre kevesebb hangot hallasz, egyre kevésbé érzel... Levegőért kapsz ahogyan a mellkasod behúzódik a medence fala jobban rád szorul... többet már nem húzódik be.");
                                                Console.WriteLine("╔═══╗─────────╔═══╗\n║╔═╗║─────────║╔═╗║\n║║─╚╬══╦╗╔╦══╗║║─║╠╗╔╦══╦═╗\n║║╔═╣╔╗║╚╝║║═╣║║─║║╚╝║║═╣╔╝\n║╚╩═║╔╗║║║║║═╣║╚═╝╠╗╔╣║═╣║\n╚═══╩╝╚╩╩╩╩══╝╚═══╝╚╝╚══╩╝\n");
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("\t - ! - A játék során egy macskának sem esett bántódása! - ! -\n\t");
                                                Console.ForegroundColor = ConsoleColor.White;
                                            }
                                        }
                                        if (meghalsz == 5)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("\n- + - 7. nap - + -");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("Beleeszel a palacsintába, szokatlan íze van, de nem törődsz vele. Egyszer csak valami hasító fájdalmat érzel, hátrébb lépsz és ránézel az ételre. Látsz benne egy kis sárga kockát, lehet hogy az okozta a furcsa ízt?\nVége.\nPatkány méreg... hirtelen a fájdalmaid közepette levegőt sem kapsz. Ugrasz egyet hátra, amivel lelökőd az egyik poharat... de többé nem löksz le semmit.");
                                            Console.WriteLine("╔═══╗─────────╔═══╗\n║╔═╗║─────────║╔═╗║\n║║─╚╬══╦╗╔╦══╗║║─║╠╗╔╦══╦═╗\n║║╔═╣╔╗║╚╝║║═╣║║─║║╚╝║║═╣╔╝\n║╚╩═║╔╗║║║║║═╣║╚═╝╠╗╔╣║═╣║\n╚═══╩╝╚╩╩╩╩══╝╚═══╝╚╝╚══╩╝\n");
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("\t - ! - A játék során egy macskának sem esett bántódása! - ! -\n\t");
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }
                                    }
                                }
                                if (meghalsz == 3)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n- + - 5. nap - + -");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("A gazdáid kénytelenek feltakarítani utánad, dühből kiraknak az ajtó elé. Meglátod, hogy egy nagy fekete rottweiler. Leblokkolsz, de még a reflexeid képesek annyira, hogy futni kezdj, egy kis utcába kanyarodsz, mivel ritkán jársz kint így nem tudtad, hogy az ott egy zsákutca. Pedig az volt. Sarokba vagy szorítva, nem tudsz átmászni. Látod hogy a kutya feléd fut, és '...\nVége.\nA rottweiler állkapcsai összecsattannak, a gond az, hogy te a fogai közt vagy. Egy hatalmas reccsenést hallasz... a saját bordáid... többet már nem hallod a reccsenést... de többé már mást sem.");
                                    Console.WriteLine("╔═══╗─────────╔═══╗\n║╔═╗║─────────║╔═╗║\n║║─╚╬══╦╗╔╦══╗║║─║╠╗╔╦══╦═╗\n║║╔═╣╔╗║╚╝║║═╣║║─║║╚╝║║═╣╔╝\n║╚╩═║╔╗║║║║║═╣║╚═╝╠╗╔╣║═╣║\n╚═══╩╝╚╩╩╩╩══╝╚═══╝╚╝╚══╩╝\n");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\t - ! - A játék során egy macskának sem esett bántódása! - ! -\n\t");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                            }
                        }
                        if (meghalsz == 3)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n- + - 3. nap - + -");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("A gazdáid már nagyon haragsznak rád. Este vacsora helyett odaadják neked azokat a kifliket, amiket megrágtál. Továbbra sem sikerült elérned azt amit szerettél volna.\nReggel szokásuk szerint a gazdáid elmentek dolgozni. Körül nézel a lakásban sehol semmi. Felugrasz az asztalra, de érzed, hogy valamibe beleragadt a lábad. Gyorsan leugrasz, ragasztó... próbálkoznak... Ezek után elmész és...");
                            Console.WriteLine("1: Befekszel a frissen mosott ruhák közé, hogy a sok szőr miatt újra kelljen mosni mindet\n2: Ráhánysz a lábtörlőre, hogy amikor kinyitják az ajtót szétkenjék az egészen\n\t");
                            igen = "";
                            do
                            {
                                igen = Console.ReadLine();
                            } while (igen != "1" && igen != "2");
                            switch (igen)
                            {
                                case "1": meghalsz++; break;
                                case "2": meghalsz += 2; break;
                                default: break;
                            }

                            if (meghalsz == 5)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\n- + - 4. nap - + -");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("A gazdáid végleg megelégeltek.\nAhogy beléptek az ajtón és a meglátták a meglepetésedet. Másnap beleraktak egy macskahordozóba, kivittek két-három várossal odébb, és kint hagytak az út szélén.\nTe meg vagy róla győződve hogy jól megleszel nélkülük is, sétálsz pár métert el az autótól. Érzed hogy korog egyet a hasad, azonnal rájössz, hogy ez neked nem fog menni visszafutsz az autóhoz, de az akkorra már elindult.\nVége.\nAz autó kereke ahogyan szépen lenyomta a tested az aszfaltra az összes csontod és szerved egyszerre roppant össze.");
                                Console.WriteLine("╔═══╗─────────╔═══╗\n║╔═╗║─────────║╔═╗║\n║║─╚╬══╦╗╔╦══╗║║─║╠╗╔╦══╦═╗\n║║╔═╣╔╗║╚╝║║═╣║║─║║╚╝║║═╣╔╝\n║╚╩═║╔╗║║║║║═╣║╚═╝╠╗╔╣║═╣║\n╚═══╩╝╚╩╩╩╩══╝╚═══╝╚╝╚══╩╝\n");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\t - ! - A játék során egy macskának sem esett bántódása! - ! -\n\t");
                                Console.ForegroundColor = ConsoleColor.White;
                            }

                            if (meghalsz == 4)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\n- + - 4. nap - + -");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("A gazdáid egyre mérgesebbek az összekoszolt ruhák miatt, de látszólag már elengedték a témát. Azt érzed, hogy nem foglalkoznak veled, csak az ablakból nézed, ahogyan játszanak kint a kutyával. Azt gondolod kitaláltad a megfelelő bosszút. Kimész és...");
                                Console.WriteLine("1: Kikarmolod a medence oldalát\n2: Felkaparod a bőrszék háttámláját\n\t");
                                igen = "";
                                do
                                {
                                    igen = Console.ReadLine();
                                } while (igen != "1" && igen != "2");
                                switch (igen)
                                {
                                    case "1": meghalsz += 2; break;
                                    case "2": meghalsz++; break;
                                    default: break;
                                }
                                if (meghalsz == 6)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n- + - 5. nap - + -");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("A gazdáid végleg megelégeltek.\nMásnap beleraktak egy macskahordozóba, felvittek a közeli hídra, ledobtak a hordozóval együtt.\nVége.\nZuhanás közbe kapálóztál, lökted a rácsokat, de esélytelen becsapódtál a vízbe, mindent elöntött a víz. A hordozó súlya lehúzott a folyó aljára. Sötétedik a kép, kapkodva próbálsz levegőt venni... utoljára... a légcsövedet elönti a víz... többször már megpróbálni sem tudod.");
                                    Console.WriteLine("╔═══╗─────────╔═══╗\n║╔═╗║─────────║╔═╗║\n║║─╚╬══╦╗╔╦══╗║║─║╠╗╔╦══╦═╗\n║║╔═╣╔╗║╚╝║║═╣║║─║║╚╝║║═╣╔╝\n║╚╩═║╔╗║║║║║═╣║╚═╝╠╗╔╣║═╣║\n╚═══╩╝╚╩╩╩╩══╝╚═══╝╚╝╚══╩╝\n");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\t - ! - A játék során egy macskának sem esett bántódása! - ! -\n\t");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                if (meghalsz == 5)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n- + - 5. nap - + -");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("A gazdáid végleg megelégeltek.\nAmint meglátták hogy mit csináltál azzal a székkel arra idegből utánad dobtak egy kalapácsot.\nVége.\nA kalapács feléd repül, a fény megtörik a fején ami a sok használattól már enyhén kopott, most mégis fényesebben tűnik mint bármi más. Leblokkolsz. Nem tudsz időben elugrani. Egy erős becsapódást érzel a fejeden, és... képszakadás... többet már nem látod a kalapács fényét, de mást sem.");
                                    Console.WriteLine("╔═══╗─────────╔═══╗\n║╔═╗║─────────║╔═╗║\n║║─╚╬══╦╗╔╦══╗║║─║╠╗╔╦══╦═╗\n║║╔═╣╔╗║╚╝║║═╣║║─║║╚╝║║═╣╔╝\n║╚╩═║╔╗║║║║║═╣║╚═╝╠╗╔╣║═╣║\n╚═══╩╝╚╩╩╩╩══╝╚═══╝╚╝╚══╩╝\n");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\t - ! - A játék során egy macskának sem esett bántódása! - ! -\n\t");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                            }
                        }
                    }
                    if (meghalsz == 0)
                    {
                        Console.WriteLine("Az előző nap után a gazdáid úgy gondolják, hogy még össze kell szoknotok az új kutyával, ezért őt is beengedik a házba. Te próbálod tartani tőle a távolságot, de ő mindenképpen játszani akar veled. Mivel te vagy az ügyesebb felugrasz egy szekrényre, aminek a tetején nyugodtan tudsz aludni, miközben azt figyeled, hogy a kis szerencsétlen kutya hogyan próbál téged megtalálni.");
                        Console.WriteLine("Aludtál három órán keresztül, arra ébredsz, hogy éhes vagy. Körül nézel feltérképezed a környeztet, lemászol a szekrényről, és ahogy a táladhoz érsz, azt veszed észre, hogy üres, és a kutya ott alszik mellette.\nVisszamész a nappaliba, látod, hogy az asztalon van egy zacskó kiflit. Azzal szemben a polcon látsz egy zacskó kutya kaját...");
                        Console.WriteLine("1: Visszafekszel aludni, és majd eszel amikor a gazdáid hazajönnek és megetetnek\n2: Felugrasz a szekrényre és bosszúból beleeszel a kutya kajájába\n3: Felugrasz az asztalra, és beleeszel az egyik kiflibe\n\t");
                        igen = "";
                        do
                        {
                            igen = Console.ReadLine();
                        } while (igen != "1" && igen != "2" && igen != "3");
                        switch (igen)
                        {
                            case "1": break;
                            case "2": meghalsz++; break;
                            default: meghalsz++; break;
                        }
                        if (meghalsz == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n- + - 3. nap - + -");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("A gazdáid mérgesek rád, de mivel szeretnek, nem tudják rávenni magukat hogy megbüntessenek.\nMásnap reggel kimész az udvarra, viszont mivel a gazdáid csak este jönnek haza egész nap kint vagy az udvaron.\nLátod ahogyan az autójukkal beparkolnak a ház elé. Felugrasz az ablakpárkányra, vársz egy-két percet. Látod őket bejönnek az ajtón egymással veszekednek, de te nem velük törődsz csak arra tudsz figyelni, hogy fázol, és már éhes is vagy.");
                            Console.WriteLine("1: Az ablakban ülve várod, hogy beengedjenek\n2: Elkezded kaparni az ablakkeretet, hogy beengedjenek végre\n\t");
                            igen = "";
                            do
                            {
                                igen = Console.ReadLine();
                            } while (igen != "1" && igen != "2");
                            switch (igen)
                            {
                                case "1": meghalsz++; break;
                                default: break;
                            }

                            if (meghalsz == 2)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\n- + - 4. nap - + -");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("A gazdáid idegesen, de beengednek. Veled ellentétben nem gondolják azt, hogy másképpen nem tudsz jelezni mint hogy az ablakot kaparod. Másnapra két-két csík ragasztószalagot tesznek az ablakkeretre.\nReggel szellőztetés közben...");
                                Console.WriteLine("1: Kimész az ablakon, azzal nem törődve, hogy estig nem fogsz tudni visszajönni\n2: Nem mész ki, inkább bent maradsz aludni\n\t");
                                igen = "";
                                do
                                {
                                    igen = Console.ReadLine();
                                } while (igen != "1" && igen != "2");
                                switch (igen)
                                {
                                    case "1": meghalsz++; break;
                                    default: break;
                                }

                                if (meghalsz == 3)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n- + - 5. nap - + -");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("Ugyan te azt gondoltad, hogy jól el leszel kint, ez nem volt egy jó döntés, megéhezel, és mivel nem vagy elég gyors, okos, és amúgy is el vagy hízva nem tudsz utolérni egy egeret. Látod, hogy a kutya a lakásban van. Bemászol a teraszra, ahol meg látod, hogy maradt még kint kaja a kutya tájában...");
                                    Console.WriteLine("1: Beleeszel abba a ételmaradékba amit a teraszon találtál\n2: Inkább megpróbálsz más megoldást találni az ételszerzésre.\n\t");
                                    igen = "";
                                    do
                                    {
                                        igen = Console.ReadLine();
                                    } while (igen != "1" && igen != "2");
                                    switch (igen)
                                    {
                                        case "1": meghalsz += 2; break;
                                        default: meghalsz++; break;
                                    }
                                    if (meghalsz == 5)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\n- + - 6. nap - + -");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Megeszed a maradékot, nem ismered fel az ízét, szerinted még nem is ettél ilyesmit. Nem is véletlen. Az ételben disznóhús volt, amire te allergiás vagy...\nVége.\nAz allergiás reakció következtében nem tudsz levegőt venni, kapálózol, de mind hiába felesleges. Elfekszel a földön. Kifújod a levegőt, és többet már nem is veszel.");
                                        Console.WriteLine("╔═══╗─────────╔═══╗\n║╔═╗║─────────║╔═╗║\n║║─╚╬══╦╗╔╦══╗║║─║╠╗╔╦══╦═╗\n║║╔═╣╔╗║╚╝║║═╣║║─║║╚╝║║═╣╔╝\n║╚╩═║╔╗║║║║║═╣║╚═╝╠╗╔╣║═╣║\n╚═══╩╝╚╩╩╩╩══╝╚═══╝╚╝╚══╩╝\n");
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\t - ! - A játék során egy macskának sem esett bántódása! - ! -\n\t");
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                    if (meghalsz == 4)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\n- + - 6. nap - + -");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Visszamész a kertbe, ahogy megkerülöd az épületet, látod, hogy az egyik ablak nyitva van. Felugrasz, és bemászol az ablakon, nehezen látsz hiszen nagyon nagy bent a füst, csak annyit hallasz, hogy becsapódik mögötted az ablak. Elmész a szoba végére, de az ajtó zárva, kaprod az ajtót, de az nem nyílik. Lökdösőd, de amellett hoz zárva még befelé is nyílik.\nKét órát ültél a füstben, de egyre nehezebben kapsz levegőt.\nVége.\nKapálózol, de mind hiába felesleges. Elfekszel a földön. Kifújod a levegőt, és többet már nem is veszel.");
                                        Console.WriteLine("╔═══╗─────────╔═══╗\n║╔═╗║─────────║╔═╗║\n║║─╚╬══╦╗╔╦══╗║║─║╠╗╔╦══╦═╗\n║║╔═╣╔╗║╚╝║║═╣║║─║║╚╝║║═╣╔╝\n║╚╩═║╔╗║║║║║═╣║╚═╝╠╗╔╣║═╣║\n╚═══╩╝╚╩╩╩╩══╝╚═══╝╚╝╚══╩╝\n");
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\t - ! - A játék során egy macskának sem esett bántódása! - ! -\n\t");
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                }
                                if (meghalsz == 2)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n- + - 5. nap - + -");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("Reggelszokásuk szerint a gazdáid elmentek dolgozni. Körül nézel a lakásban sehol semmi. Felugrasz az asztalra, de érzed, hogy valamibe beleragad a lábad. Gyorsan leugrasz, ragasztó... próbálkoznak... Ezek utána kimész a nappaliba, felugrasz a kanapéra, ahonnan  látod a kutyát. Békésen aludta szőnyegen. Ennél sokkal érdekesebbnek tűnik a nappali új függönye. Hosszú, sötétkék, szinte a földigért. Úgy gondolod, hogy...");
                                    Console.WriteLine("1: Felmászol a függönyre, ami a karmain nyomán végigszakad\n2:Bosszúból rátámadsz a kutyára, hiszen őt tartod azelhanyagolásod okának és nem az elviselhetetlen viselkedésedet");
                                    igen = "";
                                    do
                                    {
                                        igen = Console.ReadLine();
                                    } while (igen != "1" && igen != "2");
                                    switch (igen)
                                    {
                                        case "2": meghalsz += 3; break;
                                        case "1": meghalsz += 2; break;
                                        default: break;
                                    }
                                    if (meghalsz == 5)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\n- + - 6. nap - + -");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("A gazdáid úgy gondolják, hogy mivel veszélyt jelentesz újházikedvecükre,ezmegrémítíőket.ElkezdenekfélnitőledVajohamegtámadtad a kutyát mi választ el attól, hogy majd a gyerekeket \nÚgy döntenek, hogy bevisznek egy menhelyre. Te nem akarsz ott lenni hiányzik az otthon, hiányoznak az ismerősök, hiányoznak az ismerős emberek a ismerőshelyek, az ismerő tárgyak, biztonságos közeg. Reccsen egy zár, törik egy ajtó egy hatalmas fehér keverék kutya fut feléd\nVége.\nA kutya állkapcsai összecsattannak, a gond az, hogy te a fogai közt vagy. Egy hatalmas reccsenést hallasz... a saját bordáid... többet már nemhallod a reccsenést... de többé már mást sem.");
                                        Console.WriteLine("╔═══╗─────────╔═══╗\n║╔═╗║─────────║╔═╗║\n║║─╚╬══╦╗╔╦══╗║║─║╠╗╔╦══╦═╗\n║║╔═╣╔╗║╚╝║║═╣║║─\n║╚╩═║╔╗║║║║║═╣║╚═╝╠╗╔╣║═\n╚═══╩╝╚╩╩╩╩══╝╚═══╝╚╝╚══╩╝\n");
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\t - ! - A játék során egy macskának sem esett bántódása! - ! -\n\t");
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                    if (meghalsz == 4)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\n- + - 6. nap - + -");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("A gazdáid hazaérnek, meglátják azt, hogy mi történt a frissen vásárolt függönnyel. Már alig bírják megállni, hogy ne tegyenek kóbor macskává, de él még bennük a remény irántad. Lecserélik az összes függönyt, elpakolnak a polcokról.\nReggel szokásosan megetetnek, és elmennek dolgozni. Kisétálsz a nappaliba éppen sikerül fel ugranod a polcra ahogyan meglátod hogy a kutya feléd közeledik. Úgy döntesz, hogy elmész aludni, azzal legalább elmegy az idő.");
                                        Console.WriteLine(" Aludtál három órán keresztül, arra ébredsz, hogy éhes vagy. Körül nézel feltérképezed a környeztet, lemászol a szekrényről, és ahogy a táladhoz érsz, azt veszed észre, hogy üres, és a kutya ott alszik mellette.\nVisszamész a nappaliba, látod, hogy szemben a polcon van egy zacskó kutya kaja... ");
                                        Console.WriteLine("1: Visszafekszel aludni, és majd eszel amikor a gazdáid hazajönnek és megetetnek\n2: Felugrasz a szekrényre és bosszúból beleeszel a kutya kajájába\n\t");
                                        igen = "";
                                        do
                                        {
                                            igen = Console.ReadLine();
                                        } while (igen != "1" && igen != "2");
                                        switch (igen)
                                        {
                                            case "1": break;
                                            case "2": meghalsz++; break;
                                            default: break;
                                        }
                                        if (meghalsz == 4)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("\n- + - 7. nap - + -");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("A gazdáid kénytelenek feltakarítani utánad, dühből kiraknak az ajtó elé. Felugrasz az ablakpárkányra. Látod őket egymással veszekedve, de te nem velük törődsz csak arra tudsz figyelni, hogy fázol.");
                                            Console.WriteLine("1: Az ablakban ülve várod, hogy beengedjenek\n2: Elkezded kaparni az ablakkeretet, hogy beengedjenek végre\n\t");
                                            igen = "";
                                            do
                                            {
                                                igen = Console.ReadLine();
                                            } while (igen != "1" && igen != "2");
                                            switch (igen)
                                            {
                                                case "1": meghalsz++; break;
                                                case "2": meghalsz += 2; break;
                                                default: break;
                                            }
                                            if (meghalsz == 6)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("\n- + - 8. nap - + -");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.WriteLine("A gazdáid végleg megelégeltek.\n Kinyitják az ablakot, nem tudsz időben elugrani látod, hogy a gazdád emeli a kezét, erősen megütött mire te hátraesel, egészen bele az ablak alatt lévő kerítés drótjába.\nVége.\nÉrzed, ahogyan egy nagy fémdarab átfúródik a testeden. Egy meleg érzés önt el. Vér. Érzed, hogy tovább zuhansz... de hirtelen már nem érzed... de többé mást sem.");
                                                Console.WriteLine("╔═══╗─────────╔═══╗\n║╔═╗║─────────║╔═╗║\n║║─╚╬══╦╗╔╦══╗║║─║╠╗╔╦══╦═╗\n║║╔═╣╔╗║╚╝║║═╣║║─║║╚╝║║═╣╔╝\n║╚╩═║╔╗║║║║║═╣║╚═╝╠╗╔╣║═╣║\n╚═══╩╝╚╩╩╩╩══╝╚═══╝╚╝╚══╩╝\n");
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("\t - ! - A játék során egy macskának sem esett bántódása! - ! -\n\t");
                                                Console.ForegroundColor = ConsoleColor.White;
                                            }
                                            if (meghalsz == 5)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("\n- + - 8. nap - + -");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.WriteLine("Kint vártál egy órát amíg végül beengedtek, megetted a vacsorádat és elmentél aludni.\nReggel a gazdáid szokásukhoz híven elmentek dolgozni, miután megetettek. Visszafekszel még aludni egészen délután négyig, mikor is megint megéhezel. Látod hogy van még kajád a tálban, de van az asztalon egy darálthúsos palacsinta.");
                                                Console.WriteLine("1: Megeszed a saját kajádat\n2: Engedsz a kísértésnek és megeszed a palacsintát\n\t");
                                                igen = "";
                                                do
                                                {
                                                    igen = Console.ReadLine();
                                                } while (igen != "1" && igen != "2");
                                                switch (igen)
                                                {
                                                    case "1": break;
                                                    case "2": meghalsz++; break;
                                                    default: break;
                                                }
                                                if (meghalsz == 4)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("\n- + - 9. nap - + -");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("A gazdáid hazaérnek még őket is meglepi, hogy nem csináltál semmi rosszat.\nEgy vasárnapi nap volt, a gazdáid otthon voltak egész nap. Próbáltál közel kerülni hozzájuk, de ők kerültek téged. A gyerekek kint fürdenek a medencében. Fel akarod hívni magadra a figyelmet azzal, hogy...");
                                                    Console.WriteLine("1: Beugrasz a medencébe\n2: Kikarmolod a medencét\n\t");
                                                    igen = "";
                                                    do
                                                    {
                                                        igen = Console.ReadLine();
                                                    } while (igen != "1" && igen != "2");
                                                    switch (igen)
                                                    {
                                                        case "1": break;
                                                        case "2": meghalsz++; break;
                                                        default: break;
                                                    }

                                                    if (meghalsz == 5)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        Console.WriteLine("\n- + - 10. nap - + -");
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        Console.WriteLine("Kapálózol a vízben. Lehet rosszkor, de most jössz rá, hogy nem tudsz úszni. Egyszer csak elmerülsz, hallod a gyerekek hangját, ahogy hívják a szüleiket. Nem mernek neked segíteni, de a szülök nem érnek oda időben.\nVége.\nEgyre halkabban hallod a gyerekek hangját, míg végül teljesen eltompul... Többen nem hallasz semmit.");
                                                        Console.WriteLine("╔═══╗─────────╔═══╗\n║╔═╗║─────────║╔═╗║\n║║─╚╬══╦╗╔╦══╗║║─║╠╗╔╦══╦═╗\n║║╔═╣╔╗║╚╝║║═╣║║─║║╚╝║║═╣╔╝\n║╚╩═║╔╗║║║║║═╣║╚═╝╠╗╔╣║═╣║\n╚═══╩╝╚╩╩╩╩══╝╚═══╝╚╝╚══╩╝\n");
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        Console.WriteLine("\t - ! - A játék során egy macskának sem esett bántódása! - ! -\n\t");
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                    }
                                                    if (meghalsz == 6)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        Console.WriteLine("\n- + - 10. nap - + -");
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        Console.WriteLine("Belekapsz a medencébe, a karmod beleakad, nem tudod elengedni, magadra rántod az egész medencét.\nVége.\n Rádtkeredik, egyre szorosabb, egyre erősebb, egyre kevesebb levegő jut be, egyre kevesebb a fény, egyre kevesebb hangot hallasz, egyre kevésbé érzel... Levegőért kapsz ahogyan a mellkasod behúzódik a medence fala jobban rád szorul... többet már nem húzódik be.");
                                                        Console.WriteLine("╔═══╗─────────╔═══╗\n║╔═╗║─────────║╔═╗║\n║║─╚╬══╦╗╔╦══╗║║─║╠╗╔╦══╦═╗\n║║╔═╣╔╗║╚╝║║═╣║║─║║╚╝║║═╣╔╝\n║╚╩═║╔╗║║║║║═╣║╚═╝╠╗╔╣║═╣║\n╚═══╩╝╚╩╩╩╩══╝╚═══╝╚╝╚══╩╝\n");
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        Console.WriteLine("\t - ! - A játék során egy macskának sem esett bántódása! - ! -\n\t");
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                    }
                                                }
                                                if (meghalsz == 5)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("\n- + - 9. nap - + -");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("Beleeszel a palacsintába, szokatlan íze van, de nem törődsz vele. Egyszer csak valami hasító fájdalmat érzel, hátrébb lépsz és ránézel az ételre. Látsz benne egy kis sárga kockát, lehet hogy az okozta a furcsa ízt?\nVége.\nPatkány méreg... hirtelen a fájdalmaid közepette levegőt sem kapsz. Ugrasz egyet hátra, amivel lelökőd az egyik poharat... de többé nem löksz le semmit.");
                                                    Console.WriteLine("╔═══╗─────────╔═══╗\n║╔═╗║─────────║╔═╗║\n║║─╚╬══╦╗╔╦══╗║║─║╠╗╔╦══╦═╗\n║║╔═╣╔╗║╚╝║║═╣║║─║║╚╝║║═╣╔╝\n║╚╩═║╔╗║║║║║═╣║╚═╝╠╗╔╣║═╣║\n╚═══╩╝╚╩╩╩╩══╝╚═══╝╚╝╚══╩╝\n");
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("\t - ! - A játék során egy macskának sem esett bántódása! - ! -\n\t");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                }
                                            }
                                        }
                                        if (meghalsz == 3)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("\n- + - 7. nap - + -");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("A gazdáid kénytelenek feltakarítani utánad, dühből kiraknak az ajtó elé. Meglátod, hogy egy nagy fekete rottweiler. Leblokkolsz, de még a reflexeid képesek annyira, hogy futni kezdj, egy kis utcába kanyarodsz, mivel ritkán jársz kint így nem tudtad, hogy az ott egy zsákutca. Pedig az volt. Sarokba vagy szorítva, nem tudsz átmászni. Látod hogy a kutya feléd fut, és '...\nVége.\nA rottweiler állkapcsai összecsattannak, a gond az, hogy te a fogai közt vagy. Egy hatalmas reccsenést hallasz... a saját bordáid... többet már nem hallod a reccsenést... de többé már mást sem.");
                                            Console.WriteLine("╔═══╗─────────╔═══╗\n║╔═╗║─────────║╔═╗║\n║║─╚╬══╦╗╔╦══╗║║─║╠╗╔╦══╦═╗\n║║╔═╣╔╗║╚╝║║═╣║║─║║╚╝║║═╣╔╝\n║╚╩═║╔╗║║║║║═╣║╚═╝╠╗╔╣║═╣║\n╚═══╩╝╚╩╩╩╩══╝╚═══╝╚╝╚══╩╝\n");
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("\t - ! - A játék során egy macskának sem esett bántódása! - ! -\n\t");
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }
                                    }
                                }
                            }
                            if (meghalsz == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\n- + - 4. nap - + -");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Gazdáid későn értek haza, ezáltal sokat kellett várnod az ablakban.\nMásnap mégis úgy döntesz, hogy kimész az udvarra. Mivel már meguntad az udvart, úgy döntesz Körül nézel a környéken. Nem látod mi van a szomszéd kertjében, hiszen a kerítés telített fa. A másik oldalt viszont egy erdős részt látsz.");
                                Console.WriteLine("1: Átmész a szomszéd telekre\n2: Megnézed mi lehet az erdős részen\n\t");
                                igen = "";
                                do
                                {
                                    igen = Console.ReadLine();
                                } while (igen != "1" && igen != "2");
                                switch (igen)
                                {
                                    case "1": meghalsz += 4; break;
                                    default: meghalsz++; break;
                                }
                                if (meghalsz == 5)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n- + - 5. nap - + -");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("Átugrasz a szomszéd telekre. Körül nézel, és egy német juhász kutya áll veled szemben. Gyorsan realizálódik benned, hogy valószínűleg ez lesz az utolsó rossz döntésed. Sajnos nem elég gyorsan ahhoz, hogy elugorj.\nVége\nA kutya állkapcsai összecsattannak, a gond az, hogy te a fogai közt vagy. Egy hatalmas reccsenést hallasz... a saját bordáid... többet már nem hallod a reccsenést... de többé már mást sem.");
                                    Console.WriteLine("╔═══╗─────────╔═══╗\n║╔═╗║─────────║╔═╗║\n║║─╚╬══╦╗╔╦══╗║║─║╠╗╔╦══╦═╗\n║║╔═╣╔╗║╚╝║║═╣║║─║║╚╝║║═╣╔╝\n║╚╩═║╔╗║║║║║═╣║╚═╝╠╗╔╣║═╣║\n╚═══╩╝╚╩╩╩╩══╝╚═══╝╚╝╚══╩╝\n");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\t - ! - A játék során egy macskának sem esett bántódása! - ! -\n\t");
                                    Console.ForegroundColor = ConsoleColor.White;

                                }
                                if (meghalsz == 2)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n- + - 5. nap - + -");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("Leugrasz a fák közé, ahogyan körbe nézel lovakat látsz egy tűzrakóhely körül legelni. Nem messze egy kis elkerített részt is, a kerítése sűrű drót, nem látsz be.");
                                    Console.WriteLine("1: Odamész egy lóhoz barátkozni\n2: Nem törődsz a hatalmas állatokkal inkább megnézed mi van az elkerített részen\n\t");
                                    igen = "";
                                    do
                                    {
                                        igen = Console.ReadLine();
                                    } while (igen != "1" && igen != "2");
                                    switch (igen)
                                    {
                                        case "1": meghalsz++; break;
                                        default: meghalsz += 3; break;
                                    }
                                    if (meghalsz == 5)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\n- + - 6. nap - + -");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Beugrasz az elkerített részre. Körül nézel, és egy fekete keverék kutya áll veled szemben. Gyorsan realizálódik benned, hogy valószínűleg ez lesz az utolsó rossz döntésed. Sajnos nem elég gyorsan ahhoz, hogy elugorj.\nVége\nA kutya állkapcsai összecsattannak, a gond az, hogy te a fogai közt vagy. Egy hatalmas reccsenést hallasz... a saját bordáid... többet már nem hallod a reccsenést... de többé már mást sem.");
                                        Console.WriteLine("╔═══╗─────────╔═══╗\n║╔═╗║─────────║╔═╗║\n║║─╚╬══╦╗╔╦══╗║║─║╠╗╔╦══╦═╗\n║║╔═╣╔╗║╚╝║║═╣║║─║║╚╝║║═╣╔╝\n║╚╩═║╔╗║║║║║═╣║╚═╝╠╗╔╣║═╣║\n╚═══╩╝╚╩╩╩╩══╝╚═══╝╚╝╚══╩╝\n");
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\t - ! - A játék során egy macskának sem esett bántódása! - ! -\n\t");
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                    if (meghalsz == 3)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\n- + - 6. nap - + -");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Odamész a Legszebb, Legszimpatikusabb Lóhoz. Egy nagyjából 172 cm magas pej magyar sportlóhoz, a homokán egy csillag is van amit észre is veszel ahogyan lehajol hozzád. Nagyon barátságosan viselkedett veled, ez neked meglepő dolog, mivel rég nem viselkedett veled senki ennyire kedvesen. Este viszont ahogy új barátodat is visszaviszik az istállóba, te is haza mész.\nReggel szokásuk szerint a gazdáid elmentek dolgozni. Körül nézel a lakásban sehol semmi. Felugrasz az asztalra, de érzed, hogy valamibe bele ragadt a lábad. Gyorsan leugrasz, ragasztó... próbálkoznak... Ezek után elmész és...");
                                        Console.WriteLine("1: Befekszel a frissen mosott ruhák közé, hogy a sok szőr miatt újra kelljen mosni mindet\n2: Ráhánysz a lábtörlőre, hogy amikor kinyitják az ajtót szétkenjék az egészen\n\t");
                                        igen = "";
                                        do
                                        {
                                            igen = Console.ReadLine();
                                        } while (igen != "1" && igen != "2");
                                        switch (igen)
                                        {
                                            case "1": meghalsz++; break;
                                            case "2": meghalsz += 2; break;
                                            default: break;
                                        }

                                        if (meghalsz == 5)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("\n- + - 4. nap - + -");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("A gazdáid végleg megelégeltek.\nAhogy beléptek az ajtón és a meglátták a meglepetésedet. Másnap beleraktak egy macska hordozóba, kivittek két három várossal odébb, és kint hagytak az út szélén.\nTe meg vagy róla győződve hogy jól megleszel nélkülük is, sétálsz pár métert el az autótól. Érzed hogy korog egyet a hasad, azonnal rájössz, hogy ez neked nem fog menni visszafutsz az autóhoz, de az akkorra már elindult\nVége.\nAz autó kereke ahogyan szépen lenyomta a tested az aszfaltra az összescsontod és szerved egyszerre roppant össze.");
                                            Console.WriteLine("╔═══╗─────────╔═══╗\n║╔═╗║─────────║╔═╗║\n║║─╚╬══╦╗╔╦══╗║║─║╠╗╔╦══╦═╗\n║║╔═╣╔╗║╚╝║║═╣║║─║║╚╝║║═╣╔╝\n║╚╩═║╔╗║║║║║═╣║╚═╝╠╗╔╣║═╣║\n╚═══╩╝╚╩╩╩╩══╝╚═══╝╚╝╚══╩╝\n");
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("\t - ! - A játék során egy macskának sem esett bántódása! - ! -\n\t");
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }

                                        if (meghalsz == 4)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("\n- + - 4. nap - + -");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("A gazdáid egyre mérgesebbek az összekoszolt ruhák miatt, de látszólag már elengedték a témát. Azt érzed, hogy nem foglalkoznak veled, csak az ablakból nézed, ahogyan játszanak kint a kutyával. Azt gondolod kitaláltad a megfelelő bosszút. Kimész és...");
                                            Console.WriteLine("1: Kikarmolod a medence oldalát\n2: Felkaparod a bőrszék háttámláját\n\t");
                                            igen = "";
                                            do
                                            {
                                                igen = Console.ReadLine();
                                            } while (igen != "1" && igen != "2");
                                            switch (igen)
                                            {
                                                case "1": meghalsz++; break;
                                                case "2": meghalsz += 2; break;
                                                default: break;
                                            }
                                            if (meghalsz == 6)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("\n- + - 5. nap - + -");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.WriteLine("A gazdáid végleg megelégeltek.\nMásnap beleraktak egy macskahordozóba, felvittek a közeli hídra, ledobtak a hordozóval együtt.\nVége.\nZuhanás közben kapálóztál, lökted a rácsokat, de esélytelen becsapódtál a vízbe, mindent elöntött a víz. A hordozó súlya lehúzott a folyó aljára. Sötétedik a kép, kapkodva próbálsz levegőt venni... utoljára... a légcsövedet elönti a víz... többször már megpróbálni sem tudod.");
                                                Console.WriteLine("╔═══╗─────────╔═══╗\n║╔═╗║─────────║╔═╗║\n║║─╚╬══╦╗╔╦══╗║║─║╠╗╔╦══╦═╗\n║║╔═╣╔╗║╚╝║║═╣║║─║║╚╝║║═╣╔╝\n║╚╩═║╔╗║║║║║═╣║╚═╝╠╗╔╣║═╣║\n╚═══╩╝╚╩╩╩╩══╝╚═══╝╚╝╚══╩╝\n");
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("\t - ! - A játék során egy macskának sem esett bántódása! - ! -\n\t");
                                                Console.ForegroundColor = ConsoleColor.White;
                                            }
                                            if (meghalsz == 5)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("\n- + - 5. nap - + -");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.WriteLine("A gazdáid végleg megelégeltek.\nAmint meglátták hogy mit csináltál azzal a székkel arra idegből utánad dobtak egy kalapácsot\nVége\nA kalapács feléd repül, a fény megtörik a fején ami a sok használattól már enyhén kopott, most mégis fényesebben tűnik mint bármi más Leblokkolsz. Nem tudsz időben elugrani Egy erősbecsapódást érzel a fejeden, és... képszakadás... többet már nem látod a kalapács fényét, de mást sem.");
                                                Console.WriteLine("╔═══╗─────────╔═══╗\n║╔═╗║─────────║╔═╗║\n║║─╚╬══╦╗╔╦══╗║║─║╠╗╔╦══╦═╗\n║║╔═╣╔╗║╚╝║║═╣║║─║║╚╝║║═╣╔╝\n║╚╩═║╔╗║║║║║═╣║╚═╝╠╗╔╣║═╣║\n╚═══╩╝╚╩╩╩╩══╝╚═══╝╚╝╚══╩╝\n");
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("\t - ! - A játék során egy macskának sem esett bántódása! - ! -\n\t");
                                                Console.ForegroundColor = ConsoleColor.White;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                        if (meghalsz == 0)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("\n- + - 3. nap - + -");
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("Másnap kimész az udvarra, de mivel már unod azt, úgy döntesz, hogy felfedezed a ház mögötti részeket.\nLeugrasz a fák közé, ahogyan körbe nézel lovakat látsz egy tűzrakóhely körül legelni. Nem messze egy kis elkerített részt is,  kerítése sűrű drót, nem látsz be.");
                            Console.WriteLine("1: Odamész egy lóhoz barátkozni\n2: Nem törődsz a hatalmas állatokkal inkább megnézed mi van az elkerített részen\n\t");
                            igen = "";
                            do
                            {
                                igen = Console.ReadLine();
                            } while (igen != "1" && igen != "2");
                            switch (igen)
                            {
                                case "1": break;
                                default: meghalsz += 5; break;
                            }
                            if (meghalsz == 5)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\n- + - 4. nap - + -");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Beugrasz az elkerített részre. Körül nézel, és egy fekete keverék kutya áll veled szemben. Gyorsan realizálódik benned, hogy valószínűleg ez lesz az utolsó rossz döntésed. Sajnos nem elég gyorsan ahhoz, hogy elugorj.\nVége\nA kutya állkapcsai összecsattannak, a gond az, hogy te a fogai közt vagy. Egy hatalmas reccsenést hallasz... a   saját bordáid... többet már nem hallod a reccsenést... de többé már mást sem.");
                                Console.WriteLine("╔═══╗─────────╔═══╗\n║╔═╗║─────────║╔═╗║\n║║─╚╬══╦╗╔╦══╗║║─║╠╗╔╦══╦═╗\n║║╔═╣╔╗║╚╝║║═╣║║─║║╚╝║║═╣╔╝\n║╚╩═║╔╗║║║║║═╣║╚═╝╠╗╔╣║═╣║\n╚═══╩╝╚╩╩╩╩══╝╚═══╝╚╝╚══╩╝\n");
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\t - ! - A játék során egy macskának sem esett bántódása! - ! -\n\t");
                                Console.ForegroundColor = ConsoleColor.White;
                            }
                            if (meghalsz == 0)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\n- + - 4. nap - + -");
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Odamész a Legszebb, Legszimpatikusabb Lóhoz. Egy nagyjából 172 cm magas pej magyar sportlóhoz, a homokán egy csillag is van amit észre is veszel ahogyan  lehajol hozzád. Nagyon barátságosan viselkedett veled, ez neked meglepő dolog, mivel rég nem viselkedett veled senki ennyire kedvesen. Este viszont ahogy új barátodat is  visszaviszik az istállóba, te is haza mész.\nMásnap visszamész arra a területre, de új barátodat nem találod ott.");
                                Console.WriteLine("1: Megnézed mi van az elkerített területen\n2: Új barátod keresésére indulsz\n\t");
                                igen = "";
                                do
                                {
                                    igen = Console.ReadLine();
                                } while (igen != "1" && igen != "2");
                                switch (igen)
                                {
                                    case "1": meghalsz += 5; break;
                                    default: break;
                                }
                                if (meghalsz == 5)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n- + - 5. nap - + -");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("Beugrasz az elkerített részre. Körül nézel, és egy fekete keverék kutya áll veled szemben. Gyorsan realizálódik benned, hogy valószínűleg ez lesz az utolsó rossz döntésed. Sajnos nem elég gyorsan ahhoz, hogy elugorj.\nVége\nA kutya állkapcsai összecsattannak, a gond az, hogy te a fogai közt vagy. Egy hatalmas reccsenést hallasz... a saját bordáid... többet már nem hallod a reccsenést... de többé már mást sem.");
                                    Console.WriteLine("╔═══╗─────────╔═══╗\n║╔═╗║─────────║╔═╗║\n║║─╚╬══╦╗╔╦══╗║║─║╠╗╔╦══╦═╗\n║║╔═╣╔╗║╚╝║║═╣║║─║║╚╝║║═╣╔╝\n║╚╩═║╔╗║║║║║═╣║╚═╝╠╗╔╣║═╣║\n╚═══╩╝╚╩╩╩╩══╝╚═══╝╚╝╚══╩╝\n");
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\t - ! - A játék során egy macskának sem esett bántódása! - ! -\n\t");
                                    Console.ForegroundColor = ConsoleColor.White;
                                }
                                if (meghalsz == 0)
                                {
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("\n- + - 5. nap - + -");
                                    Console.ForegroundColor = ConsoleColor.White;
                                    Console.WriteLine("Felmész az istállókhoz. Két istállót látsz. A kisebbik istálló bejáratánál több ember is áll, látszólag figyelnek valamit.");
                                    Console.WriteLine("1: Bemész a kisebb istállóba nem foglalkozol az emberekkel\n2: Bemész a nagyobb istállóba\n\t");
                                    igen = "";
                                    do
                                    {
                                        igen = Console.ReadLine();
                                    } while (igen != "1" && igen != "2");
                                    switch (igen)
                                    {
                                        case "1": meghalsz += 5; break;
                                        default: break;
                                    }
                                    if (meghalsz == 5)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\n- + - 6. nap - + -");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Bemész az oldalsó bejáraton. Engedsz a kíváncsiságodnak és közelebb mész az emberekhez. Az istállóban rengeteg tehén áll. Ahogy közelebb érsz látod, hogy az egyikük a földön fekszik mellette egy borjúval, pár perce születhetett. Akkor meglátod, hogy mellettük áll egy fekete kutya. A kutya elkezd feléd futni, átfutott a legrosszabb eset is az agyadon. Sajnos nem elég gyorsan ahhoz, hogy elugorj.\nVége\nA kutya állkapcsai összecsattannak, a gond az, hogy te a fogai közt vagy. Egy hatalmas reccsenést hallasz... a saját bordáid... többet már nem hallod a reccsenést... de többé már mást sem.");
                                        Console.WriteLine("╔═══╗─────────╔═══╗\n║╔═╗║─────────║╔═╗║\n║║─╚╬══╦╗╔╦══╗║║─║╠╗╔╦══╦═╗\n║║╔═╣╔╗║╚╝║║═╣║║─║║╚╝║║═╣╔╝\n║╚╩═║╔╗║║║║║═╣║╚═╝╠╗╔╣║═╣║\n╚═══╩╝╚╩╩╩╩══╝╚═══╝╚╝╚══╩╝\n");
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\t - ! - A játék során egy macskának sem esett bántódása! - ! -\n\t");
                                        Console.ForegroundColor = ConsoleColor.White;
                                    }
                                    if (meghalsz == 0)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("\n- + - 6. nap - + -");
                                        Console.ForegroundColor = ConsoleColor.White;
                                        Console.WriteLine("Az istállóban megtalálod legjobb ló-barátodat. Az estét az istállóban töltöd, de reggel arra ébredsz, hogy éhes vagy. Ahogy kimész a bokszból látod, hogy a bokszsorok végén vagy egy tál étel, de tudod hogy most haza is tudsz menni mert a gazdáid egész nap otthon lesznek, hiszen vasárnap van.");
                                        Console.WriteLine("1: Megeszed azt az ételt, amit az istállóban találtál\n2: Hazamész enni\n\t");
                                        igen = "";
                                        do
                                        {
                                            igen = Console.ReadLine();
                                        } while (igen != "1" && igen != "2");
                                        switch (igen)
                                        {
                                            case "1": meghalsz += 5; break;
                                            default: break;
                                        }
                                        if (meghalsz == 5)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("\n- + - 7. nap - + -");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("Megeszed az ételt, nem ismered fel az ízét, szerinted még nem is ettél ilyesmit. Nem is véletlen. Az ételben disznóhús volt, amire te allergiás vagy...\nVége.\nAz allergiás reakció következtében nem tudsz levegőt venni, kapálózol, de mind hiába felesleges. Elfekszel a földön. Kifújod a levegőt, és többet már nem is veszel.");
                                            Console.WriteLine("╔═══╗─────────╔═══╗\n║╔═╗║─────────║╔═╗║\n║║─╚╬══╦╗╔╦══╗║║─║╠╗╔╦══╦═╗\n║║╔═╣╔╗║╚╝║║═╣║║─║║╚╝║║═╣╔╝\n║╚╩═║╔╗║║║║║═╣║╚═╝╠╗╔╣║═╣║\n╚═══╩╝╚╩╩╩╩══╝╚═══╝╚╝╚══╩╝\n");
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("\t - ! - A játék során egy macskának sem esett bántódása! - ! -\n\t");
                                            Console.ForegroundColor = ConsoleColor.White;
                                        }
                                        if (meghalsz == 0)
                                        {
                                            Console.ForegroundColor = ConsoleColor.Red;
                                            Console.WriteLine("\n- + - 7. nap - + -");
                                            Console.ForegroundColor = ConsoleColor.White;
                                            Console.WriteLine("Hazamész beülsz az ablakba, várod, hogy észre vegyenek. Próbálsz nyávogni, de a gazdádat nem érdekli.");
                                            Console.WriteLine("1: Megpróbálsz máshol bejutni\n2: Vársz még egy keveset, hátha észrevesz\n\t");
                                            igen = "";
                                            do
                                            {
                                                igen = Console.ReadLine();
                                            } while (igen != "1" && igen != "2");
                                            switch (igen)
                                            {
                                                case "1": meghalsz += 5; break;
                                                default: break;
                                            }
                                            if (meghalsz == 5)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("\n- + - 8. nap - + -");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.WriteLine("Visszamész a kertbe, ahogy megkerülöd az épületet, látod, hogy az egyik ablak nyitva van. Felugrasz, és bemászol az ablakon, nehezen látsz hiszen nagyon nagy bent a füst, csak annyit hallasz, hogy becsapódik mögötted az ablak. Elmész a szoba végére, de az ajtó zárva, kaprod az ajtót, de az nem nyílik. Lökdösőd, de amellett hoz zárva még befelé is nyílik.\nKét órát ültél a füstben, de egyre nehezebben kapsz levegőt.\nVége.\nKapálózol, de mind hiába felesleges. Elfekszel a földön. Kifújod a levegőt, és többet már nem is veszel.");
                                                Console.WriteLine("╔═══╗─────────╔═══╗\n║╔═╗║─────────║╔═╗║\n║║─╚╬══╦╗╔╦══╗║║─║╠╗╔╦══╦═╗\n║║╔═╣╔╗║╚╝║║═╣║║─║║╚╝║║═╣╔╝\n║╚╩═║╔╗║║║║║═╣║╚═╝╠╗╔╣║═╣║\n╚═══╩╝╚╩╩╩╩══╝╚═══╝╚╝╚══╩╝\n");
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("\t - ! - A játék során egy macskának sem esett bántódása! - ! -\n\t");
                                                Console.ForegroundColor = ConsoleColor.White;
                                            }
                                            if (meghalsz == 0)
                                            {
                                                Console.ForegroundColor = ConsoleColor.Red;
                                                Console.WriteLine("\n- + - 8. nap - + -");
                                                Console.ForegroundColor = ConsoleColor.White;
                                                Console.WriteLine("Másnap átlagon felülien fáradtnak érzed magadat. Bent maradsz a házban pihenni. Aludtál késő délutánig, mikor is felkelsz arra hogy megint éhes vagy. A tálad üres már korábban megetted mindet. Körbe nézel a konyhában, szerencsédre látsz a pulton egy tál életet.");
                                                Console.WriteLine("1: Megeszed a pulton talált ételt\n2: Visszafekszel aludni mivel már nem kell sokáig várnod, hogy a gazdáid hazaérjenek\n\t");
                                                igen = "";
                                                do
                                                {
                                                    igen = Console.ReadLine();
                                                } while (igen != "1" && igen != "2");
                                                switch (igen)
                                                {
                                                    case "1": meghalsz += 5; break;
                                                    default: break;
                                                }
                                                if (meghalsz == 5)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("\n- + - 9. nap - + -");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("Megeszed az ételt, nem ismered fel az ízét, szerinted még nem is ettél ilyesmit. Nem is véletlen. Az ételben disznóhús volt, amire te allergiás vagy...\nVége.\nAz allergiás reakció következtében nem tudsz levegőt venni, kapálózol, de mind hiába felesleges. Elfekszel a földön. Kifújod a levegőt, és többet már nem is veszel.");
                                                    Console.WriteLine("╔═══╗─────────╔═══╗\n║╔═╗║─────────║╔═╗║\n║║─╚╬══╦╗╔╦══╗║║─║╠╗╔╦══╦═╗\n║║╔═╣╔╗║╚╝║║═╣║║─║║╚╝║║═╣╔╝\n║╚╩═║╔╗║║║║║═╣║╚═╝╠╗╔╣║═╣║\n╚═══╩╝╚╩╩╩╩══╝╚═══╝╚╝╚══╩╝\n");
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("\t - ! - A játék során egy macskának sem esett bántódása! - ! -\n\t");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                }
                                                if (meghalsz == 0)
                                                {
                                                    Console.ForegroundColor = ConsoleColor.Red;
                                                    Console.WriteLine("\n- + - 9. nap - + -");
                                                    Console.ForegroundColor = ConsoleColor.White;
                                                    Console.WriteLine("Másnap reggel fáradt vagy ezért bent maradsz a lakásban. Arra ébredsz, hogy éhes vagy...");
                                                    Console.WriteLine("1: Megeszed a kutya kajáját\n2: Megvárod, amíg a gazdáid hazajönnek és megetetnek\n\t");
                                                    igen = "";
                                                    do
                                                    {
                                                        igen = Console.ReadLine();
                                                    } while (igen != "1" && igen != "2");
                                                    switch (igen)
                                                    {
                                                        case "1": meghalsz++; break;
                                                        default: break;
                                                    }

                                                    if (meghalsz == 1)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        Console.WriteLine("\n- + - 10. nap - + -");
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        Console.WriteLine("nReggel szokásuk szerint a gazdáid elmentek dolgozni. Körül nézel a lakásban sehol semmi. Felugrasz az asztalra, de érzed, hogy valamibe beleragadt a lábad. Gyorsan leugrasz, ragasztó... próbálkoznak... Ezek után elmész és...");
                                                        Console.WriteLine("1: Befekszel a frissen mosott ruhák közé, hogy a sok szőr miatt újra kelljen mosni mindet\n2: Ráhánysz a lábtörlőre, hogy amikor kinyitják az ajtót szétkenjék az egészen\n\t");
                                                        igen = "";
                                                        do
                                                        {
                                                            igen = Console.ReadLine();
                                                        } while (igen != "1" && igen != "2");
                                                        switch (igen)
                                                        {
                                                            case "1": meghalsz++; break;
                                                            case "2": meghalsz += 4; break;
                                                            default: break;
                                                        }

                                                        if (meghalsz == 5)
                                                        {
                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                            Console.WriteLine("\n- + - 11. nap - + -");
                                                            Console.ForegroundColor = ConsoleColor.White;
                                                            Console.WriteLine("A gazdáid végleg megelégeltek.\nAhogy beléptek az ajtón és a meglátták a meglepetésedet. Másnap beleraktak egy macska hordozóba ,kivittek két-három várossal odébb, és kint hagytak az út szélén.\nTe meg vagy róla győződve hogy jól megleszel nélkülük is, sétálsz pár métert el az autótól. Érzed hogy korog eggyet a hasad, azonnal rájössz, hogy ez neked nem fog menni visszafutsz az autóhoz, de az akkorra már elindult\nVége.\nAz autó kereke ahogyan szépen lenyomta a tested az aszfaltra az összescsontod és szerved egyszerre roppant össze.");
                                                            Console.WriteLine("╔═══╗─────────╔═══╗\n║╔═╗║─────────║╔═╗║\n║║─╚╬══╦╗╔╦══╗║║─║╠╗╔╦══╦═╗\n║║╔═╣╔╗║╚╝║║═╣║║─║║╚╝║║═╣╔╝\n║╚╩═║╔╗║║║║║═╣║╚═╝╠╗╔╣║═╣║\n╚═══╩╝╚╩╩╩╩══╝╚═══╝╚╝╚══╩╝\n");
                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                            Console.WriteLine("\t - ! - A játék során egy macskának sem esett bántódása! - ! -\n\t");
                                                            Console.ForegroundColor = ConsoleColor.White;
                                                        }

                                                        if (meghalsz == 2)
                                                        {
                                                            Console.ForegroundColor = ConsoleColor.Red;
                                                            Console.WriteLine("\n- + - 11. nap - + -");
                                                            Console.ForegroundColor = ConsoleColor.White;
                                                            Console.WriteLine("A gazdáid egyre mérgesebbek az összekoszolt ruhák miatt, de látszólag már elengedték a témát. Azt érzed, hogy nem foglalkoznak veled, csak az ablakból nézed, ahogyan játszanak kint a kutyával. Azt gondolod kitaláltad a megfelelő bosszút. Kimész és...");
                                                            Console.WriteLine("1: Kikarmolod a medence oldalát\n2: Felkaparod a bőrszék háttámláját\n\t");
                                                            igen = "";
                                                            do
                                                            {
                                                                igen = Console.ReadLine();
                                                            } while (igen != "1" && igen != "2");
                                                            switch (igen)
                                                            {
                                                                case "1": meghalsz += 4; break;
                                                                case "2": meghalsz += 3; break;
                                                                default: break;
                                                            }
                                                            if (meghalsz == 6)
                                                            {
                                                                Console.ForegroundColor = ConsoleColor.Red;
                                                                Console.WriteLine("\n- + - 12. nap - + -");
                                                                Console.ForegroundColor = ConsoleColor.White;
                                                                Console.WriteLine("A gazdáid végleg megelégeltek.\nMásnap beleraktak egy macskahordozóba, felvittek a közeli hídra, ledobtak a hordozóval együtt.\nVég\nZuhanás közben kapálóztál, lökted a rácsokat, de esélytelen becsapódtál a vízbe, mindent elöntött a víz. A hordozó súlya lehúzott a folyó aljára. Sötétedik a kép ,kapkodva próbálsz levegőt venni... utoljára... a légcsövedet elönti a víz... többször már megpróbálni sem tudod.");
                                                                Console.WriteLine("╔═══╗─────────╔═══╗\n║╔═╗║─────────║╔═╗║\n║║─╚╬══╦╗╔╦══╗║║─║╠╗╔╦══╦═╗\n║║╔═╣╔╗║╚╝║║═╣║║─║║╚╝║║═╣╔╝\n║╚╩═║╔╗║║║║║═╣║╚═╝╠╗╔╣║═╣║\n╚═══╩╝╚╩╩╩╩══╝╚═══╝╚╝╚══╩╝\n");
                                                                Console.ForegroundColor = ConsoleColor.Red;
                                                                Console.WriteLine("\t - ! - A játék során egy macskának sem esett bántódása! - ! -\n\t");
                                                                Console.ForegroundColor = ConsoleColor.White;
                                                            }
                                                            if (meghalsz == 5)
                                                            {
                                                                Console.ForegroundColor = ConsoleColor.Red;
                                                                Console.WriteLine("\n- + - 12. nap - + -");
                                                                Console.ForegroundColor = ConsoleColor.White;
                                                                Console.WriteLine("A gazdáid végleg megelégeltek.\nAmint meglátták hogy mit csináltál azzal a székkel arra idegből utánad dobtak egy kalapácsot\nVége\n Akalapács feléd repül, a fény megtörik a fején ami a sok használattól már enyhén kopott, most mégis fényesebben tűnik mint bármi más Leblokkolsz. Nem tudsz időben elugrani Egy erősbecsapódást érzel a fejeden, és... képszakadás... többet már nem látod a kalapács fényét, de mást sem.");
                                                                Console.WriteLine("╔═══╗─────────╔═══╗\n║╔═╗║─────────║╔═╗║\n║║─╚╬══╦╗╔╦══╗║║─║╠╗╔╦══╦═╗\n║║╔═╣╔╗║╚╝║║═╣║║─║║╚╝║║═╣╔╝\n║╚╩═║╔╗║║║║║═╣║╚═╝╠╗╔╣║═╣║\n╚═══╩╝╚╩╩╩╩══╝╚═══╝╚╝╚══╩╝\n");
                                                                Console.ForegroundColor = ConsoleColor.Red;
                                                                Console.WriteLine("\t - ! - A játék során egy macskának sem esett bántódása! - ! -\n\t");
                                                                Console.ForegroundColor = ConsoleColor.White;
                                                            }
                                                        }
                                                    }

                                                    if (meghalsz == 0)
                                                    {
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        Console.WriteLine("\n- + - 10. nap - + -");
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                        Console.WriteLine("Reggel úgy gondolod, hogy elmész meglátogatni kedvenc ló-barátodat.\nÁtugrasz a kerítésen kint legalább tíz ló, de Őt nem látod. Felmész az istállóhoz és látod, hogy éppen felviszik egy lószállítóra. Úgy döntesz megállítod az autót... naív... mikorra közeledsz akkorra már elindult.\nVége.\nAz autó kereke ahogyan lenyomta a tested az aszfaltra az összes csontod és szerved egyszerre roppant össze.");
                                                        Console.WriteLine("");
                                                        Console.WriteLine("╔═══╗─────────╔═══╗\n║╔═╗║─────────║╔═╗║\n║║─╚╬══╦╗╔╦══╗║║─║╠╗╔╦══╦═╗\n║║╔═╣╔╗║╚╝║║═╣║║─║║╚╝║║═╣╔╝\n║╚╩═║╔╗║║║║║═╣║╚═╝╠╗╔╣║═╣║\n╚═══╩╝╚╩╩╩╩══╝╚═══╝╚╝╚══╩╝\n");
                                                        Console.ForegroundColor = ConsoleColor.Red;
                                                        Console.WriteLine("\t - ! - A játék során egy macskának sem esett bántódása! - ! -\n\t");
                                                        Console.ForegroundColor = ConsoleColor.White;
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }



                do
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("\n\nAkarsz még játszani? [i/n]");
                    Console.ForegroundColor = ConsoleColor.White;
                    akarsz = Console.ReadLine();
                } while (akarsz != "i" && akarsz != "n");
            };
            Console.ReadKey();
        }     
    }
}