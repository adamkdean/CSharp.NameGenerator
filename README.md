CSharp.NameGenerator
====================

Simple name generator with custom phonetic patterns.


## Usage
    
    GenerateString(string pattern, string vowels = "", string consonants = "")

To generate a new string, call the `Generator.GenerateString` method, providing a pattern. The format of the pattern is simple, C for consonant, V for vowel. Spaces are permitted in the pattern. You can also supply a string of permitted vowels and/or consonants, as to restrict the letters available to give certain themes to names.

For example, here are 20 names and the pattern used:

    CVCVC - Sijel, Vibur, Hujam, Ripuk, Xumiy, Cexum, Quwec, Warol, Gapaz, Wemab, Casuh, Watej, Nofic, Mayuq, Noxid, Selic, Suwul, Pawah, Vejex, Pacup  
    
    CVV - Wii, Mie, Fau, Pio, Feo, Rue, Cie, Fuo, Vai, Nii, Sei, Cee, Lie, Deu, Zio, Fea, Teo, Sai, Goo, Toe  
    
    VCVC - Urok, Ugad, Alel, Ayal, Ehuq, Umoj, Uzec, Uqis, Oyet, Erop, Aduj, Ujoc, Ewil, Obil, Ujix, Ucem, Uqoc, Olaq, Ilit, Imen  
    
    VCVC CCVVC - Edob Ffuol, Uxud Vpuun, Iloq Lwouv, Emoy Lzaix, Eher Syoup, Anuw Rxauy, Usoy Hkeih, Oyib Cgooq, Ewot Yqeoj, Unux Ylaax, Akuy Hdoax, Aciq Fzeof, Adod Rraec, Itac Zxeij, Ojiq Cyoap, Ulew Rdeuc, Abok Wxaeh, Ubap Hroon, Oqaw Mmaaz, Oray Wcuen  
    
    VCVC CCVVC - Vowels: a - Ajar Pwaaf, Akas Dbaah, Ahag Hraaq, Ayab Scaaj, Azag Graaw, Acad Jhaay, Alaw Vhaax, Alac Ncaaq, Awaz Yqaah, Acay Gyaar, Agav Ysaah, Awam Lsaaz, Ayam Btaam, Abas Xhaal, Amal Gpaag, Aqaz Graaj, Awam Vtaaj, Anaj Bzaad, Amay Cnaaq, Ahaq Tpaaq  

    VVC VVC - Consonants: krs - Eus Aas, Eek Eer, Oos Ius, Ies Our, Aik Iis, Ees Iar, Iuk Aos, Ies Aar, Uas Oek, Uis Ear, Ios Eus, Uer Ias, Iir Aer, Iar Oor, Uok Oir, Ias Ois, Uar Ues, Uis Uas, Iur Eok, Euk Iek

    CVCVVC - Vowels: ou, Consonants: slnrt - Toroot, Susuos, Lotuus, Nonoor, Soluor, Rotoos, Sunous, Rurool, Luluol, Rusuut, Nonour, Loluor, Rolous, Sutour, Nunoon, Sotoul, Rosoot, Tuloor, Sosuus, Suruus

## N.B.

Names come back in lowercase by default, but if you wish to capitalise them like above, the following works great:

    var result = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(result);

Hope you enjoy using this as much as I enjoyed making it.