const apiKey = "AIzaSyAF-IV0HzOlw4uu3mrju0GA70s-Bdi-A0s"
const playListUrl = "watch?v=nHazUM0DBi4&list=RDQMARQLlfkN6JM&start_radio=1"


// Load the IFrame Player API code asynchronously.
var tag = document.createElement('script');
tag.src = "https://www.youtube.com/player_api";
var firstScriptTag = document.getElementsByTagName('script')[0];
firstScriptTag.parentNode.insertBefore(tag, firstScriptTag);

let player;
let playlist = [
    { id: 'nHazUM0DBi4&list=RDQMARQLlfkN6JM&start_radio=1', title: 'Song 1', author: 'Artist 1', duration: '3:23' },
    { id: 'B7qRzcM_0DQ&t=182s&t=14972s', title: 'Song 2', author: 'Artist 2', duration: '4:12' },
    { id: 'WnVxsr5IzUY', title: 'Song 3', author: 'Artist 3', duration: '2:45' }
]; // Replace with actual YouTube video IDs

let currentIndex = 0;

function onYouTubeIframeAPIReady() {
    player = new YT.Player('player', {
        videoId: playlist[currentIndex].id,
        events: {
            'onReady': onPlayerReady,
            'onStateChange': onPlayerStateChange
        }
    });

    // Dynamically create the song list
    const songListContainer = document.querySelector('.song-list');
    playlist.forEach((song, index) => {
        const songElement = document.createElement('div');
        songElement.classList.add('song');
        songElement.innerHTML = `
            <img src="https://via.placeholder.com/50" alt="Song Image">
            <div class="song-info">
                <h4 class="song-title">${song.title}</h4>
                <p class="author-name">${song.author}</p>
            </div>
            <p class="duration">${song.duration}</p>
        `;
        songListContainer.appendChild(songElement);
    });
}

function onPlayerReady(event) {
    console.log("Ready to play");
}

function playVideo() {
    player.playVideo();
}

function pauseVideo() {
    player.pauseVideo();
}

function nextSong() {
    currentIndex = (currentIndex + 1) % playlist.length;
    player.loadVideoById(playlist[currentIndex].id);
    updateSongDuration();
}

function prevSong() {
    currentIndex = (currentIndex - 1 + playlist.length) % playlist.length;
    player.loadVideoById(playlist[currentIndex].id);
    updateSongDuration();
}

function onPlayerStateChange(event) {
    if (event.data === YT.PlayerState.ENDED) {
        nextSong();
    }
}

// Update the song duration dynamically
function updateSongDuration() {
    const durationElement = document.querySelector('.song-duration');
    const videoDuration = player.getDuration(); // Get the current video duration in seconds
    const formattedDuration = formatDuration(videoDuration);
    durationElement.textContent = `Duration: ${formattedDuration}`;
}

// Format the duration from seconds to MM:SS
function formatDuration(seconds) {
    const minutes = Math.floor(seconds / 60);
    const secs = Math.floor(seconds % 60);
    return `${minutes}:${secs < 10 ? '0' : ''}${secs}`;
}

setInterval(updateSongDuration, 1000);  // Update duration every second
