
var images1 = ['images/katte/kat1.jpg', 'images/katte/kat2.png', 'images/katte/kat3.png', 'images/katte/kat4.png', 'images/katte/kat5.png', 'images/katte/kat6.png', 'images/katte/kat7.png', 'images/katte/kat8.png', 'images/katte/kat9.png', 'images/katte/kat10.png', 'images/katte/kat11.png', 'images/katte/kat12.png'];
var images2 = ['images/hunde/hund1.png', 'images/hunde/hund2.png', 'images/hunde/hund3.png', 'images/hunde/hund4.png', 'images/hunde/hund5.png', 'images/hunde/hund6.png', 'images/hunde/hund7.png', 'images/hunde/hund8.png', 'images/hunde/hund9.png', 'images/hunde/hund10.png', 'images/hunde/hund11.png'];
var images3 = ['images/kaniner/kanin1.png', 'images/kaniner/kanin2.png', 'images/kaniner/kanin3.png', 'images/kaniner/kanin4.png', 'images/kaniner/kanin5.png', 'images/kaniner/kanin6.png', 'images/kaniner/kanin7.png', 'images/kaniner/kanin8.png', 'images/kaniner/kanin9.png','images/kaniner/kanin10.png'];


var currentIndex1 = 0;
var currentIndex2 = 0;
var currentIndex3 = 0;

var interval = 2000; // 2 seconds

function changeImage1() {
    document.getElementById('changingImage1').src = images1[currentIndex1];
    currentIndex1 = (currentIndex1 + 1) % images1.length;
    setTimeout(changeImage1, interval);
}

function changeImage2() {
    document.getElementById('changingImage2').src = images2[currentIndex2];
    currentIndex2 = (currentIndex2 + 1) % images2.length;
    setTimeout(changeImage2, interval);
}

function changeImage3() {
    document.getElementById('changingImage3').src = images3[currentIndex3];
    currentIndex3 = (currentIndex3 + 1) % images3.length;
    setTimeout(changeImage3, interval);
}

/* Start the image changing processes*/
setTimeout(changeImage1, interval);
setTimeout(changeImage2, interval);
setTimeout(changeImage3, interval);



