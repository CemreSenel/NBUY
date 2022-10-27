/*
    ES6-Ecmascript

    Değişkenler tanımlanırken 3 farklı keyword uygulanabilir
    1-var
    2-let
    3-const(sabit)


    -ES6 ile birlikte artık modern javascript tabiri kullanılmaya başlanmıştır.
    Bu süreçte let ve const kullanılır.


    -Js te değişken tanımlanırken tip belirtilmez
    Bu değişkenlerin tipi olmadığı anlamına gelmez.

    -Js motoru bır değişkene değer atanması esnasında o değere göre tipi belirler.

    -Eğer bir değişkene değer atanmamışsa undefined olarak belirlenir

*/  

// let yas=20;
// console.log(yas);

// let ad= 'gec kalan harun';
// let soyad= 'gec kalan sema';
// console.log(ad);
// console.log(soyad);
// console.log(ad,soyad);

// let firstName='Serhat';
// let lastName='Kaya';
// console.log(firstName + ' ' + lastName);


// let sayi1=15;
// let sayi2=25;
// let sayi3=35;

// let s1=15, s2=45, s3=55;

// let say1=25,
//     say2=55,
//     say3=48;


// let durum=true;

// sayi1=125;

// console.log(sayi1);

// let toplam=0;
// toplam= toplam + sayi1;

// const benimDogumYilim=1995;
// console.log('Benım dogum yılım: ' + benimDogumYilim);


/*
Bildiğimiz degısken ısımlerdırme yontemlerı kulllanılır.
Degışkenleri genellıkle camelCase ile isimlendiririz.
degısken ısmı rakamla baslayamaz
-Reserved Keywordler degısken adı olarak kullanılamaz


-Const sabıt degerlerı tutmak ıcın kullanılır.Genellıkle tamamen buyuk harf ıle ısımlendırılır


*/ 

// const PI_SAYISI = 3.14;
// const _PI_SAYISI =3.14;

// const RENK_1 = 'sarı';
// const RENK_2 = 'lacivert';

// let renk_3 = 'yeşil';

// console.log(RENK_1,renk_3,RENK_2);


//DATA TYPES

//1-NUMBER

// let sayi1=100;
// console.log(sayi1);

// console.log(typeof sayi1);
// console.log(typeof(sayi1));

// let sayi2=17.5;
// console.log(sayi2);
// console.log(typeof sayi2);


// let sayi3=25/0;
// console.log(sayi3,typeof sayi3);

// let sayi4='okul'/25;
// console.log(sayi4,typeof(sayi4));

// let sayi5=99999999999999999999999999999999999999999999456451531516315135154154135415161531351515135151351511315151684n;
// console.log(sayi5,typeof(sayi5));

// let sayi6=sayi5*999999999999999999999999999999999999999999999999999999n;
// console.log(sayi6,typeof(sayi6));


//STRING
/*
    String ıfadeler uc farklı sekılde ıfade edılebılır
    1-tek tırmak ('')
    2-cıft tırnak ("")
    3-(``)


*/ 

// let ad= '"ENGIN"';
// let soyad="'NIYAZI'";
// let adSoyad= ad + ' ' + soyad;
// console.log(adSoyad);

// let adres = 'Halit aga mah.\n\tSütlü nuriye sok. Candaş apt. no:21\n\tBeşiktaş';
// console.log(adres);


// let adSoyad='Cemre Şenel';

// let yas =27;
// let kanGrubu= '0 rH+';
// let kilo=65;
// let cinsiyet='erkek';

// console.log('Ssyın ' + adSoyad+ ',' + yas + ' yasındasınız.\nKilo:' + kilo + '\nKan Grubu:'  );


// console.log();
// console.log();

// console.log(`Sayın ${adSoyad}, ${yas} yasındasınız.
// Kilo: ${kilo}
// Kan Grubu: ${kanGrubu}
// Cinsiyet: ${cinsiyet}
// ` );

//BOOLEAN
// let durum = true;
// console.log(durum,typeof(durum));

// let ad = 'Halil';
// console.log(ad,typeof(ad));

//null , undefined
// let yas;
// yas=null;
// yas=12/0;
// console.log(yas,typeof(yas));


//Javascriptte char dıye bır tıp yoktur.

//Convert-Data types
// let durum=true;
// console.log(durum,typeof(durum));

// let metin='Durumunuz '+ durum +' şeklindedir';
// console.log(metin,typeof(metin));

// let durumMetin=String(durum);
// console.log(durumMetin,typeof(durumMetin));

// let sayi=25;
// let metin2= sayi +'yasındasınız';
// console.log(metin2,typeof(metin2));
// let sayiMetin=String(sayi)
// console.log(sayiMetin,typeof sayiMetin);


// let metinSayi='455';
// console.log(metinSayi,typeof metinSayi);
// let metinSayiNumber=Number(metinSayi);
// console.log(metinSayiNumber,typeof metinSayiNumber);



// let sayiMetin='    145      ';
// console.log(sayiMetin,typeof sayiMetin);

// let sayi=Number(sayiMetin);
// console.log(sayi,typeof sayi);

// let sayi= 1254n;
// console.log(sayi,typeof sayi);


// console.log(Number(true));
// console.log(Number(false));

// console.log(Boolean(0));
// console.log(Boolean(1));
// console.log(Boolean('0'));



// let a;
// a = '' + 1 + 0; console.log(a,typeof a);
// a = '' - 1 + 0; console.log(a,typeof a);
// a = true + false; console.log(a,typeof a);
// a = 6 / '3'; console.log(a,typeof a);
// a = 4 +  5 + 'px'; console.log(a,typeof a);
// a = '$' + 4 + 5; console.log(a,typeof a);
// a = '4px' - 2; console.log(a,typeof a);
// a = '              -9        ' + 5; console.log(a,typeof a);
// a = null + 1; console.log(a,typeof a);
// a = undefined + 1; console.log(a,typeof a);









