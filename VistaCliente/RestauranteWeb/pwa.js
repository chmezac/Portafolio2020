import 'https://cdn.jsdelivr.net/npm/@pwabuilder/pwaupdate';

const el = document.createElement('pwa-update');
document.body.appendChild(el);


var deferredPrompt;

window.addEventListener('beforeinstallprompt', function (e) {
    // Prevent Chrome 67 and earlier from automatically showing the prompt
    e.preventDefault();
    // Stash the event so it can be triggered later.
    deferredPrompt = e;
    showAddToHomeScreen();
});


function showAddToHomeScreen() {
    var a2hsBtn = document.querySelector(".ad2hs-prompt");
    a2hsBtn.style.display = "block";
    a2hsBtn.addEventListener("click", addToHomeScreen);

}