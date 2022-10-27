// function selamVer(){
//     console.log('Merhaba java Script');
// }

// selamVer();


// function selamVer(isim='Dünya'){
//     console.log('Merhaba ' + isim);

// }

// selamVer('Cemre');

// selamVer();



// function yasHesapla(dogumYili){
//    return (new Date().getFullYear()-dogumYili); 
// }
// console.log(yasHesapla(1975));


// let yas = yasHesapla(1975);
// if (yas<30) {
//     console.log('yasınız uygun degıldır');
// }else{
//     console.log('kabul edıldınız');
// }


//Bir tutar bılgısı alıp bu tutarın kdv sını hesaplayın gerı donduren functıon


// function kdvHesapla(tutar){
//     let sonuc = (tutar*0.18).toFixed(2);
//     return sonuc;
// }

// console.log(kdvHesapla(100));



// function kdvHesapla(){
//     for (let i = 0; i < arguments.length; i++) {
//         console.log(arguments[i]*0.18);
//     }
// }


// kdvHesapla(100,200,1000);


//kendısıne gonderılecek tutar bılgılerını kullanarak kdvlerı hesaplayıp gerıye hesaplanmıs kdvlerı ıcınde barındıran
//bır dizi donduren functıon


function kdvHesapla(){
    let sonuc=[];
    let kdv=0;
    for (let i = 0; i < arguments.length; i++) {
       kdv = arguments[i]*0.18;
       kdv = kdv.toFixed(2);
       sonuc.push(kdv);
        
    }
    return sonuc;
}
console.log(kdvHesapla(100,450,7800));
