const HEADLINES = [
    "How the Avocado Became the Fruit of the Global Trade",
    "Why You Will Probably Pay More for Your Christmas Tree This Year",
    "Hey Parents, Surprise, Fruit Juice Is Not Fruit",
    "Visualizing Science"
];

function GetHashTags(headline) {
    let htags = [];
    let sample = headline.toLowerCase().replace(/[,]/g, "");
    let words = sample.split(" ").sort((a,b) => b.length - a.length);
    if (words.length > 3) {
        for (let i = 0; i < 3; i++) {
            htags.push(`#${words[i]}`);
        }
    }
    else {
        for (let i = 0; i < words.length; i++) {
            htags.push(`#${words[i]}`);
        }
    }
    return htags;
}

var HTML = "";
var tags = [];
for (let i = 0; i < HEADLINES.length; i++) {
    HTML += `
    <h2>${HEADLINES[i]}</h2>
    <div class="h-tag-container">
    `;
    tags = GetHashTags(HEADLINES[i]);
    console.warn(tags);
    for (let j = 0; j < tags.length; j++) {
        HTML += `
            <div>${tags[j]}</div>
        `;
    }
    HTML += "</div>";
}


document.getElementById("output").innerHTML = HTML;