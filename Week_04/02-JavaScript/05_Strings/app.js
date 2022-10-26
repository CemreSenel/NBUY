let ders = 'Bahçeşehir Üniversitesi Wissen Akademie Iğdır';
let sonuc;

sonuc=ders.toLowerCase();
sonuc=ders.toLocaleLowerCase();
sonuc=ders.toUpperCase();
sonuc=ders.toLocaleUpperCase();

sonuc=ders.length;
sonuc=ders[44];

sonuc=ders.slice(0,10);
sonuc=ders.slice(20,25);
sonuc=ders.slice(10);

sonuc=ders.substring(0,10);
sonuc=ders.substring(10,0);

sonuc=ders.substring(20,25);
sonuc=ders.substring(25,20);

sonuc=ders.replace('Iğdır','İstanbul');

sonuc=ders.replace(' ','-')


sonuc=ders.trim();
sonuc=ders.trimStart();
sonuc=ders.trimEnd();


sonuc=ders.toLocaleLowerCase().indexOf('a');

sonuc=ders.split(' ');
console.log(sonuc[3]);

// Kullanıcının gırdıgı bır cumlenın kac sozcukten olustugunu bulun

//  let cumle = prompt('Lutfen bır cumle gırınız:');
//  let sozcukDizisi= cumle.split(' ');
//  console.log(sozcukDizisi.length);


sonuc=ders.includes('Akademie');
sonuc=ders.startsWith('Bahçeşehir');
sonuc=ders.endsWith('r');




console.log(ders);
console.log(sonuc);