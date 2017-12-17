using System;
using advent_of_code.Days;

namespace advent_of_code
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExecuteDayOne();
            //ExecuteDayTwo();
            //ExecuteDayThree();
            ExecuteDayFour();
        }

        public static void ExecuteDayOne()
        {
            var partOneInput = "68376334795224855827459835293967497295464175589881588256882344699473595413912688278647235862566123233983921662578792917453912795352746426512649965615919588512125567186837411371179875287621488759761429629174886972298349197722423458299323141529413191327622485249495864168181327197661454464926326248274999448373741839963155646828842752761293142356422964355349521987483211496361289666375779728345952231649453711684539164893151811849653331845998998597991146881361717234517911759893792348815818755262456378627116779495435596139617246571678531183335956244163871445674244765586446362529159854137535962117184875192273872222899887357292312978286182636232921252574738118347521187637829623831872437381979223955675634257889137823684924127338433248519515211796732599314921611399736571277222546332369461136277417419794865524123989722492356536832313937597437717873787593849468836733642529378547151146397532997237439387663769334722979172954835154486382983716698212694357398153392926255272961384626131829678171219569288685597141132355322788254163923888378155573948753185423158997877718687642446457446643422536541238979761725496426292359382168535641216124211741896552562128941824172241913873537828976172738276983915232241451589421911121567228899853934667954786256223614621554618294467191255153395256524786159758429643756586457639177183891162214163549688595416893383194995824534247841414247526268212761954913719452114876764745799982792594753759626334319631191917894368116738893548797661111899664138398354818931135486984944719992393148681724116616741428937687985152658296679845474766477741553632712968679175356452987459761126437216758171182395219393289199148996813762849991484678429793578629331215796996751484375784895561682156658579887518746862371751372692472765217374791324656745291574784495299477362964676351148183676897122366838656342745944945275263617729359831466565694983217252594237828187612857523344265418227883219383138893873384775659548637662867572687198263688597865118173921615178165442133987362382721444844952715592955744739873677838847693982379696776";
            Console.WriteLine($"Day One Part One: {DayOne.PartOne(partOneInput)}");
            
            var partTwoInput = "68376334795224855827459835293967497295464175589881588256882344699473595413912688278647235862566123233983921662578792917453912795352746426512649965615919588512125567186837411371179875287621488759761429629174886972298349197722423458299323141529413191327622485249495864168181327197661454464926326248274999448373741839963155646828842752761293142356422964355349521987483211496361289666375779728345952231649453711684539164893151811849653331845998998597991146881361717234517911759893792348815818755262456378627116779495435596139617246571678531183335956244163871445674244765586446362529159854137535962117184875192273872222899887357292312978286182636232921252574738118347521187637829623831872437381979223955675634257889137823684924127338433248519515211796732599314921611399736571277222546332369461136277417419794865524123989722492356536832313937597437717873787593849468836733642529378547151146397532997237439387663769334722979172954835154486382983716698212694357398153392926255272961384626131829678171219569288685597141132355322788254163923888378155573948753185423158997877718687642446457446643422536541238979761725496426292359382168535641216124211741896552562128941824172241913873537828976172738276983915232241451589421911121567228899853934667954786256223614621554618294467191255153395256524786159758429643756586457639177183891162214163549688595416893383194995824534247841414247526268212761954913719452114876764745799982792594753759626334319631191917894368116738893548797661111899664138398354818931135486984944719992393148681724116616741428937687985152658296679845474766477741553632712968679175356452987459761126437216758171182395219393289199148996813762849991484678429793578629331215796996751484375784895561682156658579887518746862371751372692472765217374791324656745291574784495299477362964676351148183676897122366838656342745944945275263617729359831466565694983217252594237828187612857523344265418227883219383138893873384775659548637662867572687198263688597865118173921615178165442133987362382721444844952715592955744739873677838847693982379696776";
            Console.WriteLine($"Day One Part Two: {DayOne.PartTwo(partTwoInput)}");
        }

        public static void ExecuteDayTwo()
        {
            var partOneAndTwoInput = @"414	382	1515	319	83	1327	116	391	101	749	1388	1046	1427	105	1341	1590
960	930	192	147	932	621	1139	198	865	820	597	165	232	417	19	183
3379	987	190	3844	1245	1503	3151	3349	2844	4033	175	3625	3565	179	3938	184
116	51	32	155	102	92	65	42	48	91	74	69	52	89	20	143
221	781	819	121	821	839	95	117	626	127	559	803	779	543	44	369
199	2556	93	1101	122	124	2714	625	2432	1839	2700	2636	118	2306	1616	2799
56	804	52	881	1409	47	246	1368	1371	583	49	1352	976	400	1276	1240
1189	73	148	1089	93	76	3205	3440	3627	92	853	95	3314	3551	2929	3626
702	169	492	167	712	488	357	414	187	278	87	150	19	818	178	686
140	2220	1961	1014	2204	2173	1513	2225	443	123	148	580	833	1473	137	245
662	213	1234	199	1353	1358	1408	235	917	1395	1347	194	565	179	768	650
119	137	1908	1324	1085	661	1557	1661	1828	1865	432	110	658	821	1740	145
1594	222	4140	963	209	2782	180	2591	4390	244	4328	3748	4535	192	157	3817
334	275	395	128	347	118	353	281	430	156	312	386	160	194	63	141
146	1116	153	815	2212	2070	599	3018	2640	47	125	2292	165	2348	2694	184
1704	2194	1753	146	2063	1668	1280	615	163	190	2269	1856	150	158	2250	2459";

            Console.WriteLine($"Day Two Part One: {DayTwo.PartOne(partOneAndTwoInput)}");
            Console.WriteLine($"Day Two Part Two: {DayTwo.PartTwo(partOneAndTwoInput)}");
        }

        public static void ExecuteDayThree()
        {
            var partOneInput = 325489;
            Console.WriteLine($"Day Three Part One: {DayThree.PartOne(partOneInput)}");
        }

        public static void ExecuteDayFour()
        {
            var partOneInput = @"oaoe rxeq vssdqtu xrk cjv yaoqp loo
mveua dogbam szydvri hyzk lbega abzqw xwjn wniug kwbre
npaoy uivpxwd oynpa rcdk uixpvdw
yserir iikzcm ieuroca iuwcfov rvb giti crdpdcv mxpps
spyuhgo lucasl ucllsa bymnjig yflbv nxitmlf
xlxyhwz xla mpye fvjegwg fezlfrt inetrh vhg xpvstx ydhvq
xgue cvtmh myg ontvvyw ygm oqzrdrw
srdfsjf dli kccb kauk kauk apa doefc cdffkhh cdffkhh
msizb elqiov lqn epamk onmnlst baawab ncafwaf jrataml iyzhy svycuec
wdzqpcn dkgdumv wdzqpcn qxdmwib cjsigi bgcihgh fmua
kpvbzf kpvbzf svyq flg shwtgp
ywrynt cesjtgk hsvitr brpiul lxgvvrl cesjtgk cesjtgk xuflpfn
tik mrpht gkv unqp wypscc vmwiu ldrigk okbc wztc
zpy kyzvijv bilpf etbrgk edza vuz jzgn
yoa rgppd kzpopd cffjk murcb jmt raace iwt
aobgkja drc ztkd qskxxbv lve lev rhhoqex bmd eolf ybxjr yiiut
zhjcfms fpabnu aozp delsc mge yqi eovg pwefafe
gukf iys qztqxz xhsssz pfqq slg jdbp pfqq yabztc asow ygh
fmr ijgmjrc zbhwsmx ylgccz ycydcyx hjjset
zybsr iqisbs hffmij ikby lwufzvg gwd
ruk rku kur ydurp upmebe
baqide zdijcf ezqfe ovrldez delzrov szimd irmk busim ppv zepqk mlwpl
bxlvp dxumme byaada cgyn diz
xlxr jhili bmcke nkl vuhqsn lxzb zmyuxgk qcqr tyxe
wvth gyerrd yewrta kgri yewrta
fall jpyuusu lffybb ivmtmzx alfl yjupusu
lzvcg xwnt mjyiklh vwlz qejj mjyiklh dmcwq qejj
vgutb smc yvnsbgd bxmjd qmhia krxz luhgg emnrp
uuvhtia aiuutvh brstbr tsrbrb
howd japlq lhk qtsfdq htfufj qkyywy anxxxqw jtmryw cdtajh
pksswl jprpccl wpklss yyrbo
furp pfru bftha iekamfc bixwmr sslovex
nrqobo hyb byh hby
mugix kzlbtuq hmju ysstccs hmju btsuh
hsrlhw zilj jtvto zilj fjq
lvol xic hqqdeo gmsug yqe wue vhmrq buj juv wxexdot
lqeybb odpv mttm bxqy vqbqr ylbei wyjcxco urufsuz kyq
youbiz kvrea xsfcp zaz zybiou earvk qpf
bowsref ooobtic apiushu kplpyza
hxfhoyy ybbe ceebt recegzz ftnlv ukaf gpvx opvd lqnvk ybbe ygnwa
jpbgc aahm aahm aahm
qyvheb xyb elt oaksuj dvgpmel poiowc ykgbgpz dxpit ytg
vgsv yrjo vjss kyfvim izwo yrjo vgsv
hkk xmqx crlki dtp nuh okef okef xomktit viia nuh tplhrx
bmkjclx sbwe bwes bsbnqd nqbsbd
gfwrl vocwln hsuxkz zpclb qprrvlt bkcluvs pqy sxucrla npb fensz
adjklj nyr btmav roxv jrri vqfnis gzsab ogskmaj
bvjm fer ztgfx mtp vvhps hptzrar wpy yhvmh qklfwpf edgrdts vmhhy
lngra nrlga xokqu mgq
mksdk bkkbfsq hazlai nixee vyxh hpvebeg jujoqe wkw mzpxixm
kxrkkx qivtt xsm xsm rqvgdjl jilosjs rji
xiqga rez igqxa odiilj izoiwf xgqia
aepioo krcr aepioo jhigtx krcr qubkv jgo zybyvy wbsguz
ntyscmf duwvvb kga xvaypk sfjlg daguzm kqat otj zmnki
ggxaery jazo ggxaery zevobo zux wfnd wbyd hmhmo oaakvab jsimsw
vqdnvgy qiex yqeweds yqvdvgn iqcukgc bvrc osi
esjzak krwe ivbri hnbah iuvb begybsk ctxmlym gjqi lcscum
hyxdilx tsv evckza bdbscwj jlihiqk dciuj hamd dqsm ydihxxl
lurtwhx ygwf pwhj whxtrlu zfvywxr gcrl zvl wienpqb woto
mfaektr ocvho ukfx ukfx old daqwotk pybjtiz kumkiq tmql lqou tmql
guwy ceqsyvs svteymr nrovwz tesymrv rmsveyt
pigilsu zpyiohn zpyiohn xzl pryi zpyiohn ohdz
pziqfg hhrzdr wxl zpqigf
psnmnxz oed edo deo
tkdp tkdp auozn tfyo wmp jtp wjyskeh dag ojdvw gbptp deiqi
xkr nmsbk mreiv occcvva eca bupc gvaoopu jdhr flh ptgdumz mks
dlevn vmwzws dlevn dlevn
qwx qnuqgc rtzc yvym sft wxq fhv fts nyvrfxz ydjvcq tnwz
debkk pullndo ezaibw ldnloup nllupdo wiiw nij
hng rpd aud epq opzjh jnzge
rmtauf nwinyl nwnliy pjzahm lywnin
cgiv omva fos irse uytiqu iqjo riplx capa dhdl echbyjw cutfam
fqrqmi jfrj zllh gfhhq fqrqmi mmyqv
yoepae uabuxlz jzqy yoepae sxena jzqy
bfr jlrycal ndg xejwjdp khwg wckevqb tud xljzem ntfbazf lkr
aomdwt sji sij jsi wlsvvva kgjzqj whhf
ogorbil orlgiob iorlbog xapwiqs jxb
tnn sxgdikv ynick ynick aumwthl rwhx eqxd jdbzyk kbil pmnifp dpeips
vzeoilq son olqvh jawmny
vsifce kcighpn mubl zkgwm
ncagxs ilohd lyq oqhjf nfeij qmtvf qpru tfmtaj
pfjkcpr dqrfde efqddr edqdrf
wdyygax hscx ptmro wqko ecnfkhj ywui
gdv nrnrzdc vyq vyq vesrj vyq jwxg
oqhrr daoew zpoduh zwmoss nfkh vubf xza kju rhrpt fvsc
oqp ppyq swvin mut uacwd swivn ucdaw icfj ldcujh cejl
dar bqp ajdhuej sxwt bqp tppexrh tppexrh
sitplaj xnb ldopp mqd gwtk uhnvozu ljz dqm ylzy qltf gwtjksx
eqkvncb jdp pahwje avhrer awb zqnwfhx zohmcz fitbyab
xlnel gjzviy cndpuoj jvwxs qsd kwli quisju kyoix imzg
czqjkk evyima ixpelbv eobpd wwuxxof pbxc dgj
czsigs lbdaynp amsexn aemsxn easnmx rsitdzf
xdpc xfbp lrjwlo ntnnob sbe bse
suud fws zgn kvfimsi
wnexa diexvky oemdq uasxzhq qxa kevyixd lpw unluohs
ylruxt beqvn vbenq ogsov mvftu sovog gshtb qriaxko vthgfr jwj
gmz wcjb cqjlb hijz qwuluuf xdpu jybdf ajiv xizwb
fcxos spz idg rjb uhr ert bxia urh xfxp ixba bnvxy
uxiie eixiu wgmwbj euiix qknyd wtaojk naeqfz qmhnulk uscgwxa
qwyxd jno xelqd isdjht qxz dbwnr bfzhewu opxmkgj igfiuck
ljpphwc ijzic pfsemsc mfedoxy pad wsk beqjpbj gbjr imce xumhr
causc ogypj csacu pdokc itpgjl xfx nyt yytg srhrup bontz xbalwnj
asohjj qer pfgwo qgdw wgdq
gpzvyhh tsnx tyu kswlgb whju zkkpdm bmh hdov
unux lhrn unux lhrn rxr
epq ksew pqct jib pqebafk jib pyfjy gnu pqct
anzbbs oyhm moyh mhyo
dpk zael zael mxots zfcum
aehljyc wrj lfhife xbss ztszba vlg eljycah ihffle coypll
aoqedco bogk bogk aoqedco sanwwo
udmbz yxe dft rzolgtp nwwjpti
efu qcls rtx mestnqt pkh ciekj scrv uswd oroowx lcztvt
urnwt uapni ood lzce
zjiqxt jzqxti infgde xbmi kawilp kaipwl
lsfn kxfw zgzdfq meqwql zpqqu otert
taajsho gbeoguv bpi nxeuy
dpoyzi rqlzx rqlzx udhuwjm qnu bnuma udhuwjm gfezx cbjpfp woir
mjbv isni ixjtjue fwsk ncgwpn vqnmq pivz jbmv qoakqou argval dacvksc
xxjcn amdgdhh iup hlk xxjcn elx
gyhocay ofqosv nldfqay aqu dsrz lmekze bus lmekze gfoq lmekze vkor
xidyqq bimvxu zrkg rpcdca ymg nmxkkqu gygcmp euemr
gvd ywog ywog gvd hwjzzq
byu ggpwrl lpexjcf hgy jee febgcae valcgc tcfwicu texqi lxfjepc qeraxcs
lkjejsb eonp jtsbps pfvlos neop ikwnb avzxnk
big pjgttfb eetr jobjfae odvl jheh tuz ystrh tuz tuz ige
czubaxq czubaxq pbxgs jhuopn snmhhc qwmcka xdhxfuz jhuopn eummw
xdwduc sqcano zopaco ozbbc bczob eas cbbzo
oanpgo tiav bbssup ttzchih tpb xmfnqwa ghdx uepmz fzqbx
ahha zsbdq jggv zfcjdp dzcfpj dkew jxmelbf jgsohj oghsjj
awdy plulzw gdi jiiq lod rog mrf uihaz sebk guvb
tlhwro sapaws ovlbbfh xctruk spzpzm latyy
ligaot xfhacs jvk xbnpu yuanx yvvi gjek
nfwuug nxccj dxpfvfq pvxcvy ayss lfwz wwole ewowl xceybeb efs zfwl
lzowlql armo yrlgfg kbl vudahci yav evdi ofak ysmfjk upe
qtmmqrl gxi rrhbi pydbopp yvevlq ovwwdrt mrppov lzzs yjyrxh srzo
hytkyas wpuqvf fftiso fftiso
yutais qjdbzo kewsi opy ysl zyvyoty wkp
qtbad bxfjkwa stcdk lyre tabdq yler
friyh ivp hshy ksmanzq mzdbbub ncbx mhzki friyh vyjk hshy
ijeysr aww evn ttqvshg xkd zjy honvuqy zyj quvyohn gphcir
okft smja fkto etb
pbi zhyy kyjdho mqsuyic vegocmw gdkskg kgavjag dbqh wamfijz ktihnrg
csqix soz ingra gvslgk
ugxgzqt pdn hiynufo lpfabmi rmwj uhsqoo pmlzad ferdup guzqtxg voxd
wkixiq vck vck sylv ttqcbwv ywqta vblz mhohx frv
phns ozeghgm dfodkyv iyc psnh tedotyz xqz gqbyj ydttezo kxgju mvip
chc jdjo pyq usyn vtrbnq ohnx dsxpdzn mgbc ysun mlalmu mqemyuw
qrkosx wcwcv brvbwo nvxwg bvrwob
bovt gpb rwm gpb pitttl rwm rvfzn tbo
zczkb tmpwtj kackkx yzqkzso rsg ema ereo jptvfd jptvfd flbjfii
fcdyetv jqelvx jlevqx cfvetyd
dtyp wfh rxtpwr nolbro iozrs mnshu tkesvyk pkmkf
lvecoh ohpb brlqwx immgqe dzfac bwlrxq hng clxmpd qodfyv
sjbc dsoqk dqosk iyla lqzrsgi tjgt mfxshtd ztmc
nxveg vmxf jwnub kujji aqkonjl xtit xitt
jsft pmojruo vtvjox wimrlhj rezqi rnv hjnvdka
vnl vzgltnl mry kkqf fekwjw knsrvt nct kqy infvys
jbvm igq gvcl crry ylia nbqcq ouduen jklepay
ermsf emrsf uksuvz zrnlun
ecksf dkydasw wddasky pmfhi yltmedt bdovedg vfnyoze ufcki civrjs ohozga
hvf gfqgc adbeykt jdz zmgonhi yua kifxyoy umsza ivnbvoc whnpi gtbinze
nmy fsdu myn iiw
yrkwca jkxc yrkwca yrkwca kxqtvqh
ildxc taopx spykdz dzbpcxp wzgka cbyr xpvrzbk
qqp axdmvo cmppp shx
uldyu luyud uduly rgcmugh
woc vjdpyq cwshqq tlh fzyuz cbwgp egpy sfw
adyv cnrn bhaxvx ofdbkn yxrtir cnrn
ycz ednsydc bqsdcpx adnq bydb tqy tqy vqzpy erdcnv
mouv ouiy gld stdv gwr lxlfq gdl ldg
gtx bbvr fxytm veofwp bvbr opefvw
pcf scu ovso rawtjxs kzxgnuy ifcn tvibap
ugcbob xkjgtx ugcbob ilkkx dikca wpxyq retqhlu ugcbob ylmt tigcmmm
gmnde ool qeuwc ctux
wpajwn gooy fedmjur pxiq xkyniyp xtgi eyfpc gjx
uaivt kvfyn mpsya qxu kvnyf wvoeaz mbt fkyvn
jth awxbprn kpcodj qxegybo
sfvitld mdzczg pdptzm fmz himb eutpyi mgrde gubsta tfsldvi dfistvl
piabmr fckmhrv twnlnka jyb selqflm iwcutk pvvann
uxjfm rmleg ochuj ruiq aobxbb tpuusot uhwjojw tutopus
dzj qdyxzk oan rtpz ona qkdzyx nkunr
urjydh dfreifg tmbetd aakc vdr dkdkldw xgvtfsa ivv doadb axgvstf
fdjhr ujgbj ulkm dfzh tmhx zfdh ckt ortg
obe ywwge rgqmt cfcnyt atn fdkdrwz lmb zwpe sqfoc yllxs akdlsso
ckhbu jfqhkml abenw ckp xvjy wsyhxox jzsz hqksq
tjx zlh zgyrjpe bdorry uofh hgkzl ezixges kaxlkjw ztijupu hlgkz
belj ipbygk dxe cqoyukw jnncelh ihvom qstbowu rocqsz ifiztlf fjrf nsit
vyswalv reaqae hzoqyun lbci ibqfljz cgjflqf kos
njrzfvu nxw nxw bdsgnxp
gxlgn qrx nspbvl pzuob nggxl ipak wjr lggxn zas
xkd sooef fsayaob tfsiyl
ecldvh jugto ghfpbev xzlc
rpyattn spb ajdplq eaorgi ackirxg knrap cobdeu qca pkp zkc
bhh tczwffg bhh bhh hrjx jwyu gry kkgghnx
zsav frsakbr bvzd gafr homzjw frsakbr yasgz homzjw kqa
nbd mekhfif mekhfif keuoag nbd
mzv vzm utuxhuf uufuhtx
siy tdbii qtu yrxar ruubale yrxar lsvnr yqxq ruubale
wstykuz fxnuszr tgmkw eovvrd ohheh raf degh hzoeun tiou wpt cqnw
dzbyhrv vzlbvn ncoa xfglcye ncoa sykfps ghi
lvi ilv xalhd ztejzb
zaeu diz zaeu gtdjsz fmoxgju diz uvh
zef lmkqlcs jnhgqww qsm fuatcq ixfa
wgp gvu rpmxrjh yokepvc yokepvc lywdl bbvvbf yokepvc
etjfs gjh tvmxb agovg yihn rmmh nue jfil
zgcco slios jbfodb wpthe ydvit regizw regizw qosou slios cto jfz
kmmq lnafaha ddos hrsjtxk zjch rfynx eovks
ezeuzu jfpv oinrstv vsw naoz enrcy svw jfvp kgmfwf cfisxzo
ljtv watps equf ljtv equf
axijki zotolsi ryqujrm xmhug fhz lkgaw umzokxh ktr jsdsfat trk iosoztl
vpqvvvn ydjz tcqc asffcxr rxb fyt vyham fys
agxrcxl obcncq htod ved ozesk obcncq iwqmksk fsijtg iidyy lxu ozesk
orsyqt otqrys pnaax qtrsoy
oyisc chu ahdp abhbtry kjsqve tkpux tkpux sxzu sxzu
wquw umlbwf mxzdbvb upp fopxe aub bau eritni punrpfc esnkyg
jjlzy hozskgo jjlzy aiq jjlzy sgfyhsd
ejghc ejghc ejghc igacslu
unzmg fugzotb nxkdlds ewn hydj fbr iuly oiwwkbg scnozau sfi dsishk
xuhjduu hfloaga xhuuduj mbavfkd nrnl ral erc mntev elpoqgq
seydro onpi qjey skgkiox fbdgyt xhr rhvz dpsjcj tfzd spjdcj btqn
difyxz cdm jlzsz oycm txyssd wckqshu ihya yjyb
nmrhlif wcreso chtqfov qcftvoh lqp egd erc myep plq cjdh
hcnwgkq kkrpxxj gwe xqgea kkrpxxj nxz mumqbw kwxhlz kkrpxxj otqy
rxbioyf cszah mhu mhu mhu
qpbrf jzink ojy idt nrjykzu
omnrq kkol dex eaqdmej dnpaum ynnntw ddwewsh ztcenhc zqdrq hmi
ngmqpu owmcuz gop gdbsfc nyott cdsflq ngmqpu
srus lrexy aqgkqvm tiyjm
wxa qopky glaaekv ykopq lna gyxvpx xwa hly dbvo
vqf sqrqw phxn xiw gejyzip ugg gghhugl zyqae
ylj cyolrx giim yrchuu yrchuu ylj
rixa yfusuqn yfusuqn yfusuqn
lpm gboakz ylyv gje yxu ahokxb ixwnpu hlcka cndhbbm nkmvts xdtqbc
veul zjvz regtyp njwfpm
pdlyjbn edawa xbcmyew gme yuk yek nfknzgn ehjz
rcgun ulv ntbwnvg ptf givapv bych gmxxxf iajqpb gwh ipavvg
qvpwk grbb gptdgrh sij vunv hsb uegsmt uos vkxdd
iun aagzlj elqcq vkrk awl yyt dxfhkwq hbkeht
cgf omofuz zddgwef iyosk hmou
mvjorn zseyo wpfjlac kpxb dlh ggo zgxoso txzuy jfbmv lacjpwf vha
twrsrw pxv iklzg rtfcl kfbcjix uyvowpa kfbcjix ofnsf adqm
qvi ivr plxfrg awugjh fxbv ztlljk qvi jdkfts xyq jdkfts uqwgdr
phs eimuuf lmxq wmp
laf gmuowr rplgkh orentm whor lkrhgp mjwr zapz mdqtqyq ttkfkf
fxk wdbl fjh ojqxp yvs fkx ysv ngksb
oclyxqu tpajqun vvmj twin zclk
srcwxs xiduxd tqpfc sbqybp sdtzw gizfn bpji kaolpuy
pfkmk olmsaz uffy uyff
crpazh pcrzha lew lkhcjij stfxq
nkbb rnlo icnzg rnlo ejanu mofx ujblud
abte xnjfo boz fnxzid nqfhifm jmnmsgh
lvck nfll szdgrxc nghig szdgrxc oytahh cibk szdgrxc
sduf jgv rrt spxw fdus
gplutjv ufep fuzrnj tmko zzpj cpd mvtrzq
ycdiav qvr ycdiav tjngezs mphk oykgcei ycdiav
egbkscg ksgcbeg qmw jdbj
kbgx otnfyc agouh iai lyhqd yzihyq ouagh snzhxa xyxrgz
kdpqljx rin dlxms ukdzedc duezdkc ikgplm ffk vdmie qziajdf ftfwl
prrzhj okffaot tlrxpjd aquc dbonaef enfdoab nwbtuh
vyzf ijo cdhek bvlgxt kvldmp kvldmp vfvg
zhijgyb yfkkal utb brew vfj ztiftq
kodsuol ubnbdv iozwfum ayqxgnj qkp yiiv wbkgi psi wnfa epw
iok mecjsp lccn nrb kobca wkznctc afjjlrt
yrw yhsva hgx nxjfbb
dbdj vef xjssylt hjlld bqbmx ihfmz uhij zoh opzrmy mfq
wqhcq usyfuc wqhcq pmf aryq nhvtkh
nkviwge snpfdza nadzfsp evvdnrl qled ekqs qumle myhky
rgljws kjuk txgeein ajmph pjhdy pmvr upae yfh
vmepn wekgc qfwybl midbac vmepn ddqmbu vmepn uhfccp yuh zzz gnx
hyqv fud xdc bssziiv mwo xfrsn xqehs mwo
djhr qxhfy vdjs ueoi mbmwa lkeumzd hyxfq krbyy ywvcstf wdkum xfqyh
heprtex wgxpign lvm vlm ypswfxr ggxipwn hdszz blrv ppy
fwalim sbqj zewxcaf qjsb cjgujwr uclxro wceu wmaifl rnd
gmivd spncot jxeycn notspc nzb wie ceyjxn xlam
cfujai hfvux hhtwe hfvux oputz oam
gmwu xwthnkp xwthnkp mdxa xwthnkp
shfqzi hdq uyyqjrd wczfvy wciko hdq nuywebl
dtkq qnb uzmo ypxfja cekqe cekqe tnaibc uzmo pmtnb
apdz exdze pop pvm pce hywvftx jrjezgd jkajq jcdjli
satq czv cfhyca cshnyh cshnyh rcu cshnyh
mxp ujq fmrnzxx xqv mxp
nel whnnxak lwzlre mrxq kpo pko bsa gimtzwb
okssco iuke vcnv okssco liawwc vcnv aztl
kjvq rye eawplkw qzxt jkqv bxbfyv
bphssax ylemih wsm jnpxce jgh repsyj ieypbz asx
dwivit ptcwt qwectqk ttwcp bklpa ivditw
ies knj zemmcto mczotme yanr kjdrwr mcry ndols
dqzdpg adb ulsv ulsv qux ppmoru sjcn dpihqz
akazkk kssdguo cgigktm indfh wwh kevuhv dclpjv kgtd ehjxous
spogxy jyzhag qumd brk cbu akbpjxb spie
jgyn cxbar axtkwh hktgcm cfsla xll rpauwl cgpziuh dyc brcxa
dodey dysnjxe kzmyytw tzddd cnupwmv
nqab whxkb kvc kvc jcjhywy mbbpfwj fxozlt whxkb qwz
ihmif xhjc lmfk yjrsioo uvtd qvtqsgt dqd
uvzedxd afli hkrigd lkzkzu ncki toam hoaefui
zmvywjv jsjf nrbrgt mbs yog eexuo
ukzab euwb qnkanyt lgeqf qefgl ewub
zbol bolz ilncu ciunl
hjryu qyl ajwju rplplr skbdsl xvto
ojfotbx zvta jofxtbo ejjnhi jyeiz yzeij
ivr pvrwef ivr zgnm jscgaoq hfjuzju cea hfjuzju ehszaz
yikp gul ugbniac jehm fwqxb hqbhi hlfr iyuuf vacrao fwqxb
plsjh efu napxwe jfxfjz efacqcp sythfxc sythfxc napxwe qncqc
meuf rcjzf mhluz kbrk tzjrcn omoiprl khs oyzad yuzbz
exvzzuc ckqfivf uoyidkg mwztyf wxtg uzrls gudioyk wfihpzn tdmwhf
qoovwqm bldswvy xkb yqrcluk qyrclku cluqyrk qgakbv urclhse
rmmymgg ytpqtuq ibt tmedibz tmbsdg ytpqtuq cxbnng
qkyeo frjjht vkpt ikztq avzqon diw noqzva dvkhwdt
opz usos kdqseyb cdxvve nahjc hbr rhsfm hcjna wnczls kky
sgeml uyaoe ked utxab hxqa glems wbdo kzrjsq
isp bmebt becira ixoz yeakj fmueu
jrd qyys cik bmaief zxllza rsu swvodiv ivvdsow ikpvwaj jdr qte
gzjjre tkjhdn lrqmvw gues ositymc xhfiutm
kcnble oxoh zggvo zjz auub kunoj snil zggvo lgql
yyfmd wbwmizs vmb clba bpzzjz nlt wgukoe hedlp osxz
skic mgcr chkj eiiy kdhch gcanziz dpecug fccp
jhnejy akpwbj mhrunvm wjzwyhe lwxostl gfe niuhj iuf bewur
nuursk gehzvck szm fllr bfaq ijpjp gehzvck bfaq
ecx etrsadp lyekp lxf flx tadreps
gbo wzkner hky ggoqu
yiitvf tyvifi xpnbk iiytfv
okpjxyq mmxcha pujgv ltgfdk wpporh bfle tuupth ukyyjgv vlnwhz
phbs qtpolnh udito ukx kjqsi jbwf sgkkwgm udito mwwb wihg
mces dhc qccy sxyilmb qmki dyqnr qsh aigaemz oofdw hbifiz
yyben jjklnz whwswg tox vgytp noijcv jjsa ybney eyrvg htjl vxli
detb tus rloz zymvmg zpe
usvkehi kxgvo rna scnaljd jmowud ipfkkf rxvpie nxysvj pvquagf fjhsvef
ytosun puwdoix oyc qdufuw ysunot
htw biy htw oxot oxot
xgzi nbq lxxtmt nbq lxxtmt fnzmmno
lko bdbj kcqvc torg enbfbj sbooco afjbclm dendwq
cgih ikmfn lyhzhxd ubq ixrori tofbo
glfhfzs gihsccj yic mlci slne
wdiu lhl hdlhzo voo yhqckcy axnz yqyi fyss qhvtsbc
aotbk zfokegh uax myhehay terwus hmzic fdwojh wjuwlp
ucbiex eigq qqe ifqw sxakwl xkwsal qeq
pknvybh qkrwi povvd phairw qst inklob yrryv bcuv dolvr okwe iexrpbw
kkah qrt dihygsm nly rblqvrm sxguxj yspmre
gzhhkjt uimif bssle vdiaa wkohq nrgboi htkojiw
aeb xihgva vwcjbjh lri nlwbxun sargiey uyekrc
fnnwfbj yyccaxu fhqb nlmwhc ymbqky ooljix mfijg ryykirn womn rygezi qsdwgpw
itfs udfr sitf gml
gknztly vay ypy jpid pyy mbpfmwz pfmzbwm qqec
bbhmw uus xffgd xcjzrlk kyecv zcerxe
ncpc otqzotf godtu yhcpsyw ncpc fbs
ggoiqm ofk pryqt kqdbo ktek kklhlju iqgmgo gqoimg flscx
gsgmvy tktzj kgi ikyz pthtk hxt gik
bunvugy fefqpkk juwk aent
atm tma dzyret jmuqke xbayiit jumqke
dilfw qws ldwfi lnujld ywrogk kjh adaj khmlb hkbml
veaemc xugf udpphf mydi jbvebgp ngyhly pufdph vbgepbj
vyd tisntn qmc yzal
uxdlc piw mwjnk qiar xwpspf sxktemh jmw
qhhvar pox aed bgwq doe uyktv pox vriy ndel pzx aed
tswei dtfb yhj krxu yqio wtzpm wtzpm yqio
bjzp zzp qdzdfv tzkbl nggbfqs vquqds xiud xgrkb
ffvjfwp jbzslqo ffvjfwp pchzrqv ffvjfwp pkd nlav
czepixn yurmsw ucckih qqlnxjj exipznc
xeu llc jnmp dmz pnmj stqzao
fzvu uscqp xerkzkg roivhri fzvu yiwae xguz ajpg
qdzk uyyoi cspmnc qdzk nwknfx fnngvla cbl
acg utwrv cahupdm xgat elb aemkf wmkdzj kfmae ahlrwu yxfcj
vdumh rcd rgc hpqk qeum fpgva qkhmuji rjxpuzk ommk
ztvm ntxkav ajv avj ippodg sukg bivcslu tes gdlrbnt bdlkaye xpgslef
aygsym pwq owxmx xjw
dkhykf pfqeyo lfq saoewy qldrky sdgrrcr frdqn tkfezop doo saoewy
cwof mqlscm iqxhb nnkex nxx glgpbn
noq zikmeyx yodahj ssu qqmifa plcbv rsahsd
nvc fuwiyq myv hjn rtuoq zoyp rqnt xchlrg
dziscfa nbzsuvp rbnrban cjdprp dkj zcry ckxtm
stpm ifcbmmw dpkpzo sot ydpeydw nusp nkciqa psnr
udikjfr foqnxl whq ojuspzz ddyz emdktzb gfio mnd hyb
vchdphx zkrtky ucyifqx ryzl txdixd cip aid cip
wcz ywzwpp viswpsm qfus uzopaq mhps sidjky kipvjg
wehhc rzujn urprwzw gkwzhk rhrpph xkzzl rzujn yddlb
wlhif foh rpvylg gruiqdv daih yflhbr coe yflhbr hvluddj
hfzi ffjntj fdth crkrzdr nyel nlxm cawze bfjz neixnw uygqvmw zayf
guthfwn kcinec glhaiqv rfgbi cbrm
mvqv lszqu eyjn suq lavyjbh ujivbza aianl wik noy zth
zkn ren ncoyj fppsy dwgtgqz til
ybxepr hrzcrxs zhrscxr uvpxxl eprxby vzgg
xhi zess zet mtpcu ibz nkwq cbzb etz kjjcns
kvmu rxgw xboplw enlqcxi uxysl xboplw kvmu oqxislh xeg qwhdc spsddge
dxaao ltjjn cpsvnxe core aojgu pbss nudwi
llro yoy tixzyc beim qirnb lffcr gzm
quxetbf gfpll gqyav dckhp xbfetqu xaebz xuqfteb
fblkc hsydxqt bvmwujr rak
epeohq olrwyft cmrvov fbdyxbg
uzqk pkhizw jbrnlvx aqkq mtmjmy gpcln gaqt rinrz gwis gpcln
ttkcu ttkcu mcq xao lhnxdph djj ylet atdln xao
pmwn svqktkm isopar krrfbna knrw kbm zsohxrk xlsmm knrw cmoikq etqeggc
undrw issrttk mcoe pvufl bwjwqkx jdz undrw vje
kfzqbb djpcjv ixctsvb rqsntv fcqz
agezraf ezrfaga pftdwrk slsxu axw
ezvkn smwko utdlu nizby
ygl dwtrpsh qzz cuntrr hdrn lujcx iwc bll qvjhg
jrdrvj ledrjp noqx igodve odgiev
zonvzgy ujnzj ujnzj zonvzgy ckzd
rmg lmib fdn nfd gfobw wrc iro nsz
acgxvh sdn zcef sdn jvgnmhi xitkqgy tbascbh
ykuzk ovp mikolx xxgpylt secuf yrtilra wnoypy mty lmnagx
wwmlins mxwye kjntv sadc wnvyoov rzdawl
ali ncsrq tcbjzpu oiw iimxlbp mwi hdvdl dqnicf lxit
sql vywv vycj nprzb tdqe qwvljm myhpvxy hdixbk ywqpn xvue vrno
etncz etncz czqw moz uaxbtm axlslow fhephy moz
wsriuaj umjkx mhxau luzf wmo kyx jidl ufuoz cbk
msfrvbt bxnd msfrvbt yut qwbx
rhag vfkqf rekoz buw qffvk wxs ghra
meignx dhdu xacg hmiqkd nrijc gcxa gwap lov ybtyr vol
qoqns swib mlegyjn ojdtt tvdrrhg oetg xdret nzpq
ntc zowllt dwiyht ztdeifx velaumx jfxxsqt uefmb gwn
bgykxl bykan tvvgcpa wdcsj coonage hpocfz sqmihw pnagv uozsh
wass vve ngyd yyvxmsq rsaypsa newxyc adqmbm xqsvymy ygdn idysq
ybo vpjcf tsbpc hcdszr qrxwjqr bzz tgjhkpu hgtxkt stpbc woro
ogszrg rszt owufa cohmv msygfw fud fzi lhts sfiy dfu gxsuj
fclumcq ejuj jkbu hbsv ythmpoo xdzg dkvrdue
rbf sunzzl sokgih rngqli xndnuj rbf smiea mqzpzb fwpcx smiea
uuuxchs uuuxchs fzna qlj tcjnv oghk fzna
zuiyk tbn nqma wptoecs xndgbqm mqan wmcahvm qpir
ztexf pqsc icxqsuf tkgr itnn yorg oyvqaj yoxggqk lep
ehm hysd jfv iugyt jyvh
fenjp zjtvvhb xfe dgxoah ljn ixvdyi fenjp odnlr
uosxyy euicgp lrsc euicgp mcszotm kvxrpk jfo oxu xyeiv fhdwl wbw
tsmdp gshgm kpb tlx kfznsu gglefv pkb gcnydo eavgrc rgd lgefvg
xuq svh cmzt bxxlvfm rtblxpu imuexhl lbre hqyedxa hwkgaak
hhlfj mlrdv dlsn zgcy hciiuzw uwciihz iizhcwu gwx
ukqoj kjqou hlk nfyz lusf kebvmrw ccaj ewmicq useba
jlnnl jsmox vnw ucr ggithr usqe allzc pfumkkm jlnnl
mswpbk lffjwq icc kef zlba uolrrl fqlfwj tbc
bfmra hdgczrw dgmnod afbmr fnczx
dcqrso cgbymsg jbx ofpbp rmtygip syly
yrmn wzkt lqys tzkw sqyl fxoc
wal zgjy cwnqyaf bhz dbpft owx
xnrautk dlsyot nzbohog xmzsbh soec wyy
kde jpkvbs eyzw ukgiv ggrtzcd vikgu mxqy jyh crdtgzg ebzet
psg jsykdw drpqzl qzqbge ldqpzr wsdykj lmhbldv hbognjp nqej fmxoq guuf
ueo ncedaju ijasprn rvxb mxkddl qvgdlbx bpj bpf pxewuf chvo lvrq
zlmg eciyqi xfbeoq pupyrc bfqexo ituqab pycrpu
jsk clo vqxzl aja jfbce ldov
muss tzg iksvdej zpw fxwhrv eeye fxwhrv
kjjd dzf zkppx qdwlx irudds kjgd pdrz rgogy qdwlx egx rjxldp
szjpf aouvl ehxq exqh
nzweop qlkje welkfs jqmvqi coc
ivmjzk usk auvmc vvcnwn qubihx vkms fbt udn uyto jjt kxqy
rayw ijaklcr ywra qkj qytxeh pmnfh qffvsft tyxheq
pea cqy tkg qidvx qidvx pea skgrndq
iijm xgwq zzpskl qtjezqt yqjwy dhbq
dfuv iqw iejb bjei iwq
ogrmldp xdc dcx cqhbwlp
wzwb xrjl keciql ckky litdr bmurdk anjs nyggesn ygwt svmee
bvkkzj rcr lozrw mgpwkm lwm yecsr ykl tzny aeus jmq mchopp
rsnvaa oikce angqn rnvsaa mhc
hsiov kxqpxtc rzh vjrqlx xxtkpqc wiunol qckxtpx
aosek lhi ruqgd rmr
agqvlao pvhcgz esw kwnpefs qsrvxz hgkgrs mpx odaiqi
dvqkrzf dawioo jtaco oeutol ravp apvr frjunad
wss nahhsh pfwgcfr rvvvq uqxxmhq qax vtrkfou medfj
imdyfc sez gve kgtryl kmqklg
crmg yhkpa bsfouax kyttpa who mcrbzaj kcsktxe yfv
zpw zlab pzw pwz okb
fgqlb byhkhfn qglfb ladle ifa
skr zwwjnr iub wekt biu jnrwwz
mpvt mpvt havn ztf
odqhd uxrswp ppj eztyj nxzwm fvxyadn tostwy odo abyp meqdm ktqkvh
fgufup uabd vhxem imto imto vhxem
vrpxxhi kii zwatqg nokg wesxju xplc sumte muwjj
nsse iquhoc giuv pxaa qpqn zrfk kywjr spz kgzc lfa
cjjgarr psvwoap ivijyt nfbxu ktiuy jajrgrc goyc
yrfzf wyxda gsslsy oeyve jczghf cbuwf iwnu izyrtho dyoup toizyhr vzzrr
bwqgxsr ufy cnouypd qwxbgsr efdkfe rwsblis bhvyws oodh
piqpez yhqahjp oxu qtomld
vjvpnwy kajjaim lcxmbyd fkdy ywvvnjp xcn nbwlklo
qghq mihdp vuv ocrzsw mlmkn rgnbfcm qgufcks btlulb effsrih
psazbfo vbpr efcspj yrjl pqjrfe relxjc nzzvb yviuhc
tbbhdbm uxhawtk bmdhtbb rqxrr pspjzx krtmf pnaz srcej rsjec
owikzec glvbqy jhknyuz jkaxu ldhnlpx wdp
qvuv wteohr daynue nehs gzqu porzrsk cqokye zzsbqox rqh ogxtn pskorrz
gnm grlfoon lxid isxa
jes iixswl umgbg qfixa xnecpns asm nopsmo axaopsm qahwpqd
orr auvlruu mqq uurlvua urauuvl fjrcuo mqht tkdgps tdvnhvq iezdv
txwyzy zzwk bzi etfg gtef
qyydr lllgosq qyydr lllgosq
xqm uyl ldpowm pxhi ievvvez hmhzwmr ldpowm jaw
qlvfq efgivhr rfhhu gvw bxgsrp sgbnjh ekgbp cyof rvghph nxfekia xym
lgladv ogj cir jxx msz fshf ayheu wpmke zckng vgrlv lxgmge
fcmp aabxdp hpxbb bblpy mpcf eju pnkv jxwoy hmv fgynps pbdxaa
jcrh dgg lzyiv ojop vhk vdb uinoetv
utlzcf ziizdo njffmxe uhyjxdb cztluf yjdhbxu
ubl cgz tyg nljl
slwe qaos ybcwdoh ogazkj tqh opggnzt ffrscl opggnzt izeh
evitfwb jpivmn dpnxzuf gdkx zprogl xehb
dktt kpnkizb rreq gjmosa iekdtpj rcxk eweawk qrre olv
cmcw vmw mujx mujx ypqfz
nzxcl fzwa ftcrc immendi tmxzzi hslye eibc tmxzzi
abfc jdqvk lichxx uiomtz tlq
mnkthoj nohjktm eued izmcjj
ullh wju bxfsif icnrmmj qnufw zubcnmo yewz phovhv
ndfvd gcyt wnm badaww twm jahlat ndfdv mtw xrq bechxx dnp
ceg gcxgu gnudeib utsynwx dpg wpsnp ahbbvkt wpsnp iou
wutcg congyz erkj ibtcics
xsbq lyycse qbsx ppgutls lroo tyor
hfiwoy hclhl gcwgqox ogo hlqr ultkaz yke iwohyf oog
bcl nemims udwkmlm nokck tkwny ulkihcu knwty pngamqg yxtphkn kuihlcu
nwsr enrutc eqcfb uxmdgju rfnzhsn tzk vysc
wbtki vjmkk kvjkm ibwkt sckvbv
xjxnow tli woxldj rotrtz nfkhcz ibh mla ybxldg
cwtpkhr oxywg qpwrgfm dfjpfuc kpcopa
byczby tbfkonk ytlczzf bbyczy
khuvrne rnamlgt akjtu qlx odr git xmiazr icwsxsq
jfm bneh tkdzuad bsr oruvmqq uauw zjlp gwov hot jkjbex
jjo uvk vlpy lpxd irntb uvk ehhsqv fxhvt jjo fpa
qrwu mgnw hvflf ytspp mco ikvbqg fflvh wts cbbf";
            Console.WriteLine($"Day Four Part One: {DayFour.PartOne(partOneInput)}");
            Console.WriteLine($"Day Four Part Two: {DayFour.PartTwo(partOneInput)}");
        }
    }
}
