﻿Imports Beehind.Common_Definitions
Imports Beehind.Common_Functions
Imports Beehind.keys
Imports System.Reflection

Public Class IPSWsMD5

    'iPhone3,1
    Public Const iPhone3_1___4_3_5___8L1___MD5 As String = "7219c43eea7362c7a402861f71b4496e"
    Public Const iPhone3_1___5_0___9A334___MD5 As String = "8ac7ae6a7f6fadbd34ba9abacd15e2dc"
    Public Const iPhone3_1___5_0_1___9A405___MD5 As String = "e9500cfaa75e4a0a5ef88c3d92a21563"
    Public Const iPhone3_1___5_1___9B176___MD5 As String = "706b8987b37bc99e349197ecc5e26c3b"
    Public Const iPhone3_1___5_1_1___9B206___MD5 As String = "a4f25b2af99580f1e69c8277d0208237"
    Public Const iPhone3_1___6_0___10A403___MD5 As String = "7323c6b0bac1a367d1ae59b2897b7e89"
    Public Const iPhone3_1___6_0_1___10A523___MD5 As String = "83548080f405e81e1223acb4d3f8bccc"
    Public Const iPhone3_1___6_1___10B144___MD5 As String = "f5f6588902174948c3e9d4f9b3a89e5d"
    Public Const iPhone3_1___6_1_2___10B146___MD5 As String = "65c85f58df8bb68b00aebdc46081248c"
    Public Const iPhone3_1___6_1_3___10B329___MD5 As String = "845a42c0139cdad6d373bf3414b25786"
    Public Const iPhone3_1___7_0___11A465___MD5 As String = "36f803242a01f35e47b9227babccd8c3"
    Public Const iPhone3_1___7_0_2___11A501___MD5 As String = "1c51e1883bc5b3017077672c8c20aa17"
    Public Const iPhone3_1___7_0_3___11B511___MD5 As String = "46b107f3c3c29d842f767b991001e23e"
    Public Const iPhone3_1___7_0_4___11B554a___MD5 As String = "103619647ccbcd365c0ad816280133c1"
    Public Const iPhone3_1___7_0_6___11B651___MD5 As String = "3d0d8227bd07c3b0e0d7549a0ecd463d"
    Public Const iPhone3_1___7_1___11D169___MD5 As String = "9b41651768dd716472577646ed1876db"
    Public Const iPhone3_1___7_1_1___11D201___MD5 As String = "331cfe074cab610fdc0418c46187de8a"
    Public Const iPhone3_1___7_1_2___11D257___MD5 As String = "6ed6cb1c2eac7177f96c9fbcf04a4f34"

    'iPhone3,2
    Public Const iPhone3_2___6_0___10A403___MD5 As String = "57206fff6428b27a62932837c18fc1cd"
    Public Const iPhone3_2___6_0_1___10A523___MD5 As String = "3ded74ea874786412cfb3ede58b74d36"
    Public Const iPhone3_2___6_1___10B144___MD5 As String = "5a14a53b21c8c01621117d57643dcf73"
    Public Const iPhone3_2___6_1_2___10B146___MD5 As String = "2184c60a04b4dd221136d307976c1dec"
    Public Const iPhone3_2___6_1_3___10B329___MD5 As String = "97c001bf6e4bcf5d832af97b762cae24"
    Public Const iPhone3_2___7_0___11A465___MD5 As String = "2f5308ffa5896c877dcb90f9c2422b78"
    Public Const iPhone3_2___7_0_2___11A501___MD5 As String = "a9cd01bc111c1f7ac8d416ce502c6fff"
    Public Const iPhone3_2___7_0_3___11B511___MD5 As String = "37aed790d104485e0af6672b7c9eba85"
    Public Const iPhone3_2___7_0_4___11B554a___MD5 As String = "f166f2599004de56928b7ef92db0fe3f"
    Public Const iPhone3_2___7_0_6___11B651___MD5 As String = "22940af7971bd4ea2a0a1681dfee49f3"
    Public Const iPhone3_2___7_1___11D169___MD5 As String = "01cf786d790166dcbab0cff84a82bcd2"
    Public Const iPhone3_2___7_1_1___11D201___MD5 As String = "a47bbe46e3129155c84696e45754879a"
    Public Const iPhone3_2___7_1_2___11D257___MD5 As String = "681686a3e860d3c592aa201c27e2d5a0"

    'iPhone3,3
    Public Const iPhone3_3___5_0___9A334___MD5 As String = "ac3985f710f3a0fe373881c98d322667"
    Public Const iPhone3_3___5_0_1___9A405___MD5 As String = "70aa97b9b4902ae32ea9d3d7850a5c58"
    Public Const iPhone3_3___5_1___9B176___MD5 As String = "304a0863e83aff0f88215e3f6a193002"
    Public Const iPhone3_3___5_1_1___9B206___MD5 As String = "730d2a2c760c3b8267258447ff19a064"
    Public Const iPhone3_3___6_0___10A403___MD5 As String = "0003dc6b9dacca06f6325a7af0334b49"
    Public Const iPhone3_3___6_0_1___10A523___MD5 As String = "5b8590ced08f275ad5446a16e68b77a5"
    Public Const iPhone3_3___6_1___10B144___MD5 As String = "f94dec674a21f295d78e9c09e2f4ce63"
    Public Const iPhone3_3___6_1_2___10B146___MD5 As String = "35f587e5943e74fc1fb571a6d30eb003"
    Public Const iPhone3_3___6_1_3___10B329___MD5 As String = "db301240840daee619d98d87f6c89921"
    Public Const iPhone3_3___7_0___11A465___MD5 As String = "48c27bcd5b3cac30105c75813bd158f4"
    Public Const iPhone3_3___7_0_2___11A501___MD5 As String = "88c6a46c43be3ae8229c9571053895fd"
    Public Const iPhone3_3___7_0_3___11B511___MD5 As String = "a14cc20a7aca7d0aa208d51da4f8ee52"
    Public Const iPhone3_3___7_0_4___11B554a___MD5 As String = "1c2fcb22ec2e07ed1711c943e2a2a8ff"
    Public Const iPhone3_3___7_0_6___11B651___MD5 As String = "5e24d81d54ff36177528cfe76cc14df0"
    Public Const iPhone3_3___7_1___11D169___MD5 As String = "f5315af1d854353348da7a42b7a58cf2"
    Public Const iPhone3_3___7_1_1___11D201___MD5 As String = "8954f81de3c1ff5c9348b46ce15f651e"
    Public Const iPhone3_3___7_1_2___11D257___MD5 As String = "f3206fb96ccfbf66174b26778eae1caa"

    'iPhone4,1
    Public Const iPhone4_1___5_0___9A334___MD5 As String = "34a7231d10df65bcb125c6c00c7331ff"
    Public Const iPhone4_1___5_0_1___9A405___MD5 As String = "64329412e34f7b6799db7c6cc7d8186f"
    Public Const iPhone4_1___5_0_1___9A406___MD5 As String = "5bbb77c606d4eb79a5fd8711f04b8dbd"
    Public Const iPhone4_1___5_1___9B179___MD5 As String = "f005b1e168ebc99fd37384766f8b7779"
    Public Const iPhone4_1___5_1_1___9B206___MD5 As String = "50d2ef6d24b99525786aea25bb1f69cf"
    Public Const iPhone4_1___6_0___10A403___MD5 As String = "e145b74b35bf789f82641f987d93e876"
    Public Const iPhone4_1___6_0_1___10A523___MD5 As String = "1da9eb8fb323bbff13213ddb65904701"
    Public Const iPhone4_1___6_1___10B142___MD5 As String = "73c9f3100ea2ad8d2bfa00df9ea01aab"
    Public Const iPhone4_1___6_1_1___10B145___MD5 As String = "fb0a44de96c693c944a15e3f6a60c5fa"
    Public Const iPhone4_1___6_1_2___10B146___MD5 As String = "5a59274d119990ecdead2a22b1af26ee"
    Public Const iPhone4_1___6_1_3___10B329___MD5 As String = "ecfb58ced2e5f3edf35e8b5e19b2e8ad"
    Public Const iPhone4_1___7_0___11A465___MD5 As String = "a0bd2a748c89eec279234efd59859aec"
    Public Const iPhone4_1___7_0_2___11A501___MD5 As String = "7336293f18ca28122e240261f1291632"
    Public Const iPhone4_1___7_0_3___11B511___MD5 As String = "31b71f5f2f83b19784772b1007cf5867"
    Public Const iPhone4_1___7_0_4___11B554a___MD5 As String = "4c2c203caeea82cd8023a2ce81e7e727"
    Public Const iPhone4_1___7_0_6___11B651___MD5 As String = "92bb6b7e4f737fc5f7733453f717f5d7"
    Public Const iPhone4_1___7_1___11D167___MD5 As String = "b7672a78105a067f15ab1558c882796d"
    Public Const iPhone4_1___7_1_1___11D201___MD5 As String = "b78ff0f3cd3948ce4bbcb08f11031f84"
    Public Const iPhone4_1___7_1_2___11D257___MD5 As String = "092bd120d533832e617c286f25bb218e"
    Public Const iPhone4_1___8_1___12B411___MD5 As String = "" 'rootfs key only
    Public Const iPhone4_1___8_1_2___12B440___MD5 As String = ""
    Public Const iPhone4_1___8_1_3___12B466___MD5 As String = ""

    'iPhone5,1
    Public Const iPhone5_1___6_0___10A405___MD5 As String = "81554d1996f7fbeec278789912df341b"
    Public Const iPhone5_1___6_0_1___10A525___MD5 As String = "86b12e3c252d50dfd8babcf2efef3dc0"
    Public Const iPhone5_1___6_0_2___10A551___MD5 As String = "7526b86490819768504b82b18bdf52d8"
    Public Const iPhone5_1___6_1___10B143___MD5 As String = "aa29f384c43de5b1522e00a8d6ff46ee"
    Public Const iPhone5_1___6_1_2___10B146___MD5 As String = "86fd1c935c77b2c1b1203b64edee5dc9"
    Public Const iPhone5_1___6_1_3___10B329___MD5 As String = "420c8a0d6196fdb1538f0ce44b2f7f86"
    Public Const iPhone5_1___6_1_4___10B350___MD5 As String = "74ebeb3b6ecba810b856a55cb243226a"
    Public Const iPhone5_1___7_0___11A465___MD5 As String = "440f179da12daf1f20f8b41817b92094"
    Public Const iPhone5_1___7_0_2___11A501___MD5 As String = "c8cc4d88ee796d9d81a96a218d11e8ad"
    Public Const iPhone5_1___7_0_3___11B511___MD5 As String = "bfaab9996ac6f4aba18397c5c0de5f89"
    Public Const iPhone5_1___7_0_4___11B554a___MD5 As String = "4a6f94da94b2f5599ac572266e60fa7a"
    Public Const iPhone5_1___7_0_6___11B651___MD5 As String = "89944fdd2127c80106446956ad7f38d6"
    Public Const iPhone5_1___7_1___11D167___MD5 As String = "ffe7460860ed3e333b178a1917d1c6fa"
    Public Const iPhone5_1___7_1_1___11D201___MD5 As String = "ddab62ac45642e6a909695a65c14fcc6"
    Public Const iPhone5_1___7_1_2___11D257___MD5 As String = "c701df2a8f62fef38ab0abf34e9d6233"
    Public Const iPhone5_1___8_0___12A365___MD5 As String = "8a8fecf91b3d0c15767c6f7d822b49d4"
    Public Const iPhone5_1___8_0_1___12A402___MD5 As String = "552f879a2a5df86d4a5b505b4d26e879"
    Public Const iPhone5_1___8_0_2___12A405___MD5 As String = "d3b2de3b46b5327b9ab930fc7363c1f6"
    Public Const iPhone5_1___8_1___12B435___MD5 As String = "addda3b4166960aa136f503475bb5c7a"
    Public Const iPhone5_1___8_1_1___12B435___MD5 As String = "d3beb3fa7d25e63b40a89a362196b43f"
    Public Const iPhone5_1___8_1_2___12B440___MD5 As String = "eafbde08566e06624c0d2fe0d9f3efa6"
    Public Const iPhone5_1___8_1_3___12B466___MD5 As String = "828c6a527546a7ae21ae49cd5803a679"
    Public Const iPhone5_1___8_2___12D508___MD5 As String = "0cc56920d0ef13baca045035ca6a2f3b"
    Public Const iPhone5_1___8_3___12F70___MD5 As String = "38dd2ac5b5ad53741c028e570814efd0"
    Public Const iPhone5_1___8_4___12H143___MD5 As String = "496bd64c26f0101c6f251eba7c61fed1"

    'iPhone5,2
    Public Const iPhone5_2___6_0___10A405___MD5 As String = "2daec5681e105586c929be711041626e"
    Public Const iPhone5_2___6_0_1___10A525___MD5 As String = "d614379cebad5a2f23f0db675d3929e5"
    Public Const iPhone5_2___6_0_2___10A551___MD5 As String = "af1746708dac26f6f78236bf2b262d1f"
    Public Const iPhone5_2___6_1___10B143___MD5 As String = "03b85bd144ad8b94621ba50ef7c824ee"
    Public Const iPhone5_2___6_1_2___10B146___MD5 As String = "bb727154bedf5d9ef6fcbacefa9e1f8f"
    Public Const iPhone5_2___6_1_3___10B329___MD5 As String = "4e572c648bdf60d20651f50b136475ef"
    Public Const iPhone5_2___6_1_4___10B350___MD5 As String = "e4e8c5e724bd851bf14e018fc40f2d59"
    Public Const iPhone5_2___7_0___11A465___MD5 As String = "ff2707f95282f44ac10b0e68fc2a49c7"
    Public Const iPhone5_2___7_0_2___11A501___MD5 As String = "39e2046fdf92080de2b0447054ca13bc"
    Public Const iPhone5_2___7_0_3___11B511___MD5 As String = "55be9d12e02acaef484fcf5aa2246410"
    Public Const iPhone5_2___7_0_4___11B554a___MD5 As String = "1ef42f06ee145d2a3107a0fe73bca111"
    Public Const iPhone5_2___7_0_6___11B651___MD5 As String = "e9706bb1a4e86b7af2cddc70db17cbfb"
    Public Const iPhone5_2___7_1___11D167___MD5 As String = "68107a3cb1067fa48387154dc99ab215"
    Public Const iPhone5_2___7_1_1___11D201___MD5 As String = "c839f6195f962dd94ca2921d6339efa5"
    Public Const iPhone5_2___7_1_2___11D257___MD5 As String = "4fa805f12410cc758aea8141739e433d"
    Public Const iPhone5_2___8_0___12A365___MD5 As String = "0fce7efd9a8c98286af52bd4e237827a"
    Public Const iPhone5_2___8_0_1___12A402___MD5 As String = "af81518c2b16c95ca4bd7ad81c99d53c"
    Public Const iPhone5_2___8_0_2___12A405___MD5 As String = "4a24ac30224caabde20057fd92970d62"
    Public Const iPhone5_2___8_1_1___12B435___MD5 As String = "5c31b119f6d7e5e12fd7d0270c075d0c"
    Public Const iPhone5_2___8_1_2___12B440___MD5 As String = "2f8691ac7b3aa61ec4b806bc65da636f"
    Public Const iPhone5_2___8_1_3___12B466___MD5 As String = "c57db179be0d7898829346eb821bdfee"
    Public Const iPhone5_2___8_2___12D508___MD5 As String = "f9e1bf209d786e37d6e3f41772e442ec"
    Public Const iPhone5_2___8_3___12F70___MD5 As String = "fb53dd7f4cecd7fc5515c97805769521"
    Public Const iPhone5_2___8_4___12H143___MD5 As String = "19f1a3aa9afeb089f7c10c5b5895c194"

    'iPhone5,3
    Public Const iPhone5_3___7_0_1___11A470a___MD5 As String = "d0fe161f7a496346d3ceebceb5da7c92"
    Public Const iPhone5_3___7_0_2___11A501___MD5 As String = "2a916e1794b95b3db1db65c718435501"
    Public Const iPhone5_3___7_0_3___11B511___MD5 As String = "dc47266dffa82a5948112d12e5bd96cf"
    Public Const iPhone5_3___7_0_4___11B554a___MD5 As String = "59bb5db9c59f09067a166057c9d3c179"
    Public Const iPhone5_3___7_0_6___11B651___MD5 As String = "da214c53066bea47eaecb6f199b9e8c1"
    Public Const iPhone5_3___7_1___11D167___MD5 As String = "4697f826c7c8536f87897f75a931ec6c"
    Public Const iPhone5_3___7_1_1___11D201___MD5 As String = "f356b6594e39651a7bff5f468b881ddc"
    Public Const iPhone5_3___7_1_2___11D257___MD5 As String = "cc3723d9d46ed8eb45aad0fc1806977c"
    Public Const iPhone5_3___8_0___12A365___MD5 As String = "9815bdf97ae7ccfbe8fac36a09479c08"
    Public Const iPhone5_3___8_0_1___12A402___MD5 As String = "005653d1d1e821b1410cec8ba9572352"
    Public Const iPhone5_3___8_0_2___12A405___MD5 As String = "9b18a9d5c6c71934513580b26f0423b9"
    Public Const iPhone5_3___8_1___12B411___MD5 As String = "f5979ec66b317c91d3752da12a1df88e"
    Public Const iPhone5_3___8_1_1___12B435___MD5 As String = "9c5c40b8347f08a2b83ef66eb77504d8"
    Public Const iPhone5_3___8_1_2___12B440___MD5 As String = "2d0676da27191d6319db14fc827f71ae"
    Public Const iPhone5_3___8_1_3___12B466___MD5 As String = "7472d35006c2eec000d93e3ed82e7c61"
    Public Const iPhone5_3___8_2___12D508___MD5 As String = "948099dfdc8222de59f8ec8829ddae29"
    Public Const iPhone5_3___8_3___12F70___MD5 As String = "c07fc0cacc77e08424d1a2d2a50578dd"
    Public Const iPhone5_3___8_4___12H143___MD5 As String = "1149efe2583ac05ca00c96f869fa6f96"

    'iPhone5,4
    Public Const iPhone5_4___7_0_1___11A470a___MD5 As String = "f3adb000e086f97328a549f42fde6670"
    Public Const iPhone5_4___7_0_2___11A501___MD5 As String = "dd1be7b0ed05a3c94d9b710c284b369b"
    Public Const iPhone5_4___7_0_3___11B511___MD5 As String = "1c25abb5f6e45efff6a77b73fc28c0a3"
    Public Const iPhone5_4___7_0_4___11B554a___MD5 As String = "da4e75a7fe05a0c6edf1fcd0ff39c09b"
    Public Const iPhone5_4___7_0_5___11B601___MD5 As String = "02577ea195f461884af819d96f559084"
    Public Const iPhone5_4___7_0_6___11B651___MD5 As String = "b49cd63183fbe040d8deb30fd5030f8e"
    Public Const iPhone5_4___7_1___11D167___MD5 As String = "c8ca8ad976c014399dfb0e050685b331"
    Public Const iPhone5_4___7_1_1___11D201___MD5 As String = "eb6baeb65b839f3a0806c8da498a96a8"
    Public Const iPhone5_4___7_1_2___11D257___MD5 As String = "e8234da7bed8c861c7bd82b8aac7ab8d"
    Public Const iPhone5_4___8_0___12A365___MD5 As String = "b9f691ffc537e3d6aa403faec26ef577"
    Public Const iPhone5_4___8_0_1___12A402___MD5 As String = "6f63b055f587513c2bbb319f34dd9d16"
    Public Const iPhone5_4___8_0_2___12A405___MD5 As String = "3ee45a5bca30e4165346a9ed7f303165"
    Public Const iPhone5_4___8_1___12B411___MD5 As String = "91e8ffa4fc6e6f903a969889b695c048"
    Public Const iPhone5_4___8_1_1___12B435___MD5 As String = "69d6c00219c37e64a3c0ac701755c5b0"
    Public Const iPhone5_4___8_1_2___12B440___MD5 As String = "2af01513976b109659022e50c9df6994"
    Public Const iPhone5_4___8_1_3___12B466___MD5 As String = "b054723ad4e2038cb0e240fbb3e98d53"
    Public Const iPhone5_4___8_2___12D508___MD5 As String = "d9e770e175238f6d12f9146bbe1e3c87"
    Public Const iPhone5_4___8_3___12F70___MD5 As String = "66697b2e1667ad147af98dd3e85b8b9a"
    Public Const iPhone5_4___8_4___12H143___MD5 As String = "f5d1ef5ddbe194deee15d1e318cbd959"

    'iPad2,1
    Public Const iPad2_1___5_0___9A334___MD5 As String = "ddd7bc45b65aeed8308d12facf4c32b0"
    Public Const iPad2_1___5_0_1___9A405___MD5 As String = "212dbe221793985bf832db2c0ea8b1da"
    Public Const iPad2_1___5_1___9B176___MD5 As String = "8243a202466be74c06d19b71e48388c1"
    Public Const iPad2_1___5_1_1___9B206___MD5 As String = "a8592e53fdbaf2e1474cb58b80ac2a4d"
    Public Const iPad2_1___6_0___10A403___MD5 As String = "a0e685753cd7e49c8717d3947ece258a"
    Public Const iPad2_1___6_0_1___10A523___MD5 As String = "de582cf0f21d17cbcd398493bb068349"
    Public Const iPad2_1___6_1___10B141___MD5 As String = "17e5cc66ce09b4bfdfc63fd2b315dfec"
    Public Const iPad2_1___6_1_2___10B146___MD5 As String = "89420c59c1474056c501b949944c345a"
    Public Const iPad2_1___6_1_3___10B329___MD5 As String = "10f4153ef68f9cd7274559a37b1bbd47"
    Public Const iPad2_1___7_0___11A465___MD5 As String = "38670766f123d3e68961252decad45b7"
    Public Const iPad2_1___7_0_2___11A501___MD5 As String = "131d9c30b691c2120867bee448281192"
    Public Const iPad2_1___7_0_3___11B511___MD5 As String = "797c7b0bee4c8dc3f26918845de2e4ab"
    Public Const iPad2_1___7_0_4___11B554a___MD5 As String = "fd626400c68d5850b510917a771ad12a"
    Public Const iPad2_1___7_0_6___11B651___MD5 As String = "042ada464beab780a97902dfafed616a"
    Public Const iPad2_1___7_1___11D167___MD5 As String = "8ee1c4b8dacfd044deec643d05d12908"
    Public Const iPad2_1___7_1_1___11D201___MD5 As String = "49e7d38d3c6ce4f00b2ed8a7297ac661"
    Public Const iPad2_1___7_1_2___11D257___MD5 As String = "1e4e1100a5e555d3b2a03e5097220d25"
    Public Const iPad2_1___8_0___12A365___MD5 As String = "6cd23986aebcdd502e6321a6c492d93b"

    'iPad2,2
    Public Const iPad2_2___5_0___9A334___MD5 As String = "95ff7c4a311919f04985bade7d184731"
    Public Const iPad2_2___5_0_1___9A405___MD5 As String = "a2f7b7620d2f42949d3993b413f3f29e"
    Public Const iPad2_2___5_1___9B176___MD5 As String = "47c5bbdc2455913f58b0808d80dcc934"
    Public Const iPad2_2___5_1_1___9B206___MD5 As String = "97b7b737d3b94e53103ef1d3b8b54584"
    Public Const iPad2_2___6_0___10A403___MD5 As String = "0b9abe475b93afe31deacd9005013a87"
    Public Const iPad2_2___6_0_1___10A523___MD5 As String = "d4c950a6103473e91c89935f3b49dc15"
    Public Const iPad2_2___6_1___10B141___MD5 As String = "338503678f56995faba6dc4ffdb84944"
    Public Const iPad2_2___6_1_2___10B146___MD5 As String = "4f23b718134878900298e620b1c08f0c"
    Public Const iPad2_2___6_1_3___10B329___MD5 As String = "4a4b598e19be67539d5ca7c9f118bbcc"
    Public Const iPad2_2___7_0___11A465___MD5 As String = "ca9b259c815b650b3c03b5e273293c06"
    Public Const iPad2_2___7_0_2___11A501___MD5 As String = "dacbf58eb4fb9e4497ad47851bd7de52"
    Public Const iPad2_2___7_0_3___11B511___MD5 As String = "cd56564943d1a4c025f2519e1b98d936"
    Public Const iPad2_2___7_0_4___11B554a___MD5 As String = "375dcbde6a7cd684fb8e27f3437918ed"
    Public Const iPad2_2___7_0_6___11B651___MD5 As String = "79f6cb12b23f39714a3e93a395ab4001"
    Public Const iPad2_2___7_1___11D167___MD5 As String = "88b76b40c50afc160361362bb4834dc8"
    Public Const iPad2_2___7_1_1___11D201___MD5 As String = "3816ab1d4ca7799de01b9298da2ac0d3"
    Public Const iPad2_2___7_1_2___11D257___MD5 As String = "9af770d1fbd2afec18c822afce3fc68b"
    Public Const iPad2_2___8_0___12A365___MD5 As String = "b7f914de2a57abceeee25fdd2142dc58"

    'iPad2,3
    Public Const iPad2_3___5_0___9A334___MD5 As String = "aa94e3fd4d15bfa7decdb93b170573fe"
    Public Const iPad2_3___5_0_1___9A405___MD5 As String = "67aa4ed8ab7802358c17d0e374b69372"
    Public Const iPad2_3___5_1___9B176___MD5 As String = "f851f1aa3241e2ed7e607a09b012f745"
    Public Const iPad2_3___5_1_1___9B206___MD5 As String = "9322bc573ef12f32539e4c970dea58d4"
    Public Const iPad2_3___6_0___10A403___MD5 As String = "ed3485c5ade954762cb973a5b896994f"
    Public Const iPad2_3___6_0_1___10A523___MD5 As String = "69bacecb40a408034f90527e4acbd363"
    Public Const iPad2_3___6_1___10B141___MD5 As String = "c384f5ba92857f094ff98b7a573063be"
    Public Const iPad2_3___6_1_2___10B146___MD5 As String = "aad83b16eeb90db8569ff4422f238b1d"
    Public Const iPad2_3___6_1_3___10B329___MD5 As String = "f1166027587c06fe993486a40638d407"
    Public Const iPad2_3___7_0___11A465___MD5 As String = "195090468c97dec6cf9dac9a38801d92"
    Public Const iPad2_3___7_0_2___11A501___MD5 As String = "75ff8a4252fb9ceee8a625927a9ca3e7"
    Public Const iPad2_3___7_0_3___11B511___MD5 As String = "477d424340ecd08864bd4b82dd754ddb"
    Public Const iPad2_3___7_0_4___11B554a___MD5 As String = "67469dc255204a93c8ca308f095ebb76"
    Public Const iPad2_3___7_0_6___11B651___MD5 As String = "2abf59e98dbc64a9d252bcb14fe4cb03"
    Public Const iPad2_3___7_1___11D167___MD5 As String = "b434579dae887115cbed3ab5f48fa6c4"
    Public Const iPad2_3___7_1_1___11D201___MD5 As String = "4512035fa9225208542e9c6181a00fbf"
    Public Const iPad2_3___7_1_2___11D257___MD5 As String = "65179ba8af6169cf9f07c3e0516c46fc"
    Public Const iPad2_3___8_0___12A365___MD5 As String = "f9350e594104239585ab9eab1cab4243"

    'iPad3,1
    Public Const iPad3_1___6_1_2___10B146___MD5 As String = "5ec8d569bb166adbfd29a68d8c77a6b5"
    Public Const iPad3_1___7_1_2___11D257___MD5 As String = "53ea8b874a19f2385feb509c4131acaa"

    'iPad3,3
    Public Const iPad3_3___6_1_3___10B329___MD5 As String = "1649df44c90d754b246f1371d4272b8d"

    'iPod4,1
    Public Const iPod4_1___5_0_1___9A405___MD5 As String = "ba36e09d830a088b10e4a342d372a6c7"
    Public Const iPod4_1___6_1___10B142___MD5 As String = "b41c5b614983ea1c0696369fb0af5e17"
    '---------------------------------------------------------------------------------------------------------------------------
End Class

