//Whıle


// let i=0;
// while (i<10) {
//     i++;
//     console.log(i + '.Javascript');
   
// }

//do-whıle
// let i=0;
// do {
//     i++;
//     console.log(i + '.js');
// } while (i < 10);


// for (let i = 0; i < 10; i++) {
    
//     console.log(i+1 + '.javascript');
// }

// let toplam =0;
// let i=1;
// while (i<=10) {
//     toplam +=i;
//     i++;
// }
// console.log(toplam);



// let toplam2=0;
// for (let i = 1; i <= 10; i++) {
//     toplam2 += i;
    
// }
// console.log(toplam2);



// kullanıcının gırecegı 3 sayıyı toplatan kodları for kullanarak yazınız

// let girilenSayi;
// let toplam=0;
// for (let i = 1; i <= 3; i++) {
    
//     girilenSayi = Number(prompt(i + '.sayıyı gırıınz'));
//     toplam += girilenSayi;
    
// }
// console.log(toplam);



//kullanıcı 0 girene kadar girilen sayıları toplayıp sonucu console a yazan kodu yazınız

// let toplam =0;
// let girilenSayi;
// let i = 1;
// do {
//     girilenSayi=Number(prompt(i + '.sayı: '));
//     toplam += girilenSayi;
//     i++;
// } while (girilenSayi!=0);
// console.log(toplam);

// son ornektekı gırılen sayıları da sonucta yazdıralım

// gırılen sayıları bir diziye aktararak kullanın.



// let toplam =0;
// let girilenSayilar = [];
// let i = 0;
// do {
//     girilenSayilar[i]=Number(prompt(i+1 + '.sayı: '));
//     toplam += girilenSayilar[i];
//     i++;
//     console.log(girilenSayilar[i]);
// } while (girilenSayilar[i-1]!=0);
// girilenSayilar.pop();
// for (let i = 0; i < girilenSayilar.length; i++) {
//      console.log(i+1+ '.sayi: ' +girilenSayilar[i]);
    
// }
// console.log('Toplam: ' + toplam);






//Kullanıcının ıstedıgı kadar sayı gırmesını saglayın
// sayı gırısı bıtısı için 0 a basılması gereksın
// 0a basılıp sayı gırısı bıttıgınde kullanıcıya su soruyu
//sorun: tek mı cıft mı?
//kullanıcı tek derse : tek sayıları ve toplamlarını
//cıft derse cıft sayıları ve toplamlarını yazdırın

let sayilar = [];
let i=0;
do {
    sayilar [i]=Number(prompt(i+1 + '.sayı: '));
    i++;
} while (sayilar[i-1] !=0);
sayilar.pop();

let sonucDizi =[];
let toplam =0;
let tur;
let cevap = prompt('tek mi cift mi?');
console.log('cevap:' + cevap);
if (cevap.toLocaleLowerCase() == 'tek') {
    tur = 'Tek '
    for (let i = 0; i < sayilar.length; i++) {
       if (sayilar[i] % 2 === 1) {
            sonucDizi.push(sayilar[i]);
            toplam += sayilar[i];
            

       } 
        
    }
    
}else if (cevap.toLocaleLowerCase() =='çift') {
    tur = 'Çift '
    for (let i = 0; i < sayilar.length; i++) {
        if (sayilar[i] % 2 === 0) {
            sonucDizi.push(sayilar[i]);
            toplam += sayilar[i];
        }
        
    }
} else {
    
    console.log('Lütfen "Tek" ya da "Çift" yaz')
}

console.log(sayilar);
console.log(tur + ' Sayılar: ' + sonucDizi);
console.log(tur + ' Sayıların toplamı:' + toplam);

