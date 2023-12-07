
var images1 = ['images/kat1.jpg', 'images/dog1.jpg', 'images/kanin1.jpg'];
var images2 = ['images/kanin1.jpg', 'images/kat1.jpg', 'images/dog1.jpg'];
var images3 = ['images/dog1.jpg', 'images/kanin1.jpg', 'images/kat1.jpg'];

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

// Start the image changing processes
setTimeout(changeImage1, interval);
setTimeout(changeImage2, interval);
setTimeout(changeImage3, interval);



