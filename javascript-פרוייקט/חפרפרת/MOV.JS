let loc;//לוח
let placeCaf;//מקום החפרפת 
let point = 0//ניקוד ההצלחות בפגיעת החפרפרת 
let over = 3//מס' כרטיסים לפי שלב הבסיס הוא 9
let closecard = 30000//זמן סיום כל ההגרלות
let card = 3000//זמן פתיחת הכרטיס בעת ההרגלה של החפרפרת 
let show = 2000
let mishart = 2;//מספר לבבות 
let mistak = 2//מס' טעיות  
let winer = 0;//מס' ניצחונות 
let timer

function create() {
    for (let i = 0; i < over * over; i++) {
        let bx = document.createElement("div");//יצירת קובית 
        bx.setAttribute("class", "box");//יצרנו קלאס לעיצוב 
        bx.setAttribute("my-index", i);//מס' יחודי לכל קובייה 
        console.log("myindex" + bx.getAttribute("my-index"))
        bx.style.top = `${Math.floor(i / over) * 180}px`;
        bx.style.left = `${Math.floor(i % over) * 180}px`;
        bx.addEventListener("click", clickmy)//הוספת אירוע של לחיצה לכרטיס
        document.querySelector("#bloc").appendChild(bx);//תוסיף את הכרטיס ללוח
    }
}
function heart() {
    for (let i = mishart - 2; i < 2; i++) {
        let myhart = document.createElement("div");
        myhart.innerHTML = "❤️"

        let mhart = document.getElementById("art");
        mhart.appendChild(myhart)
    }
}

function start() {
    // let i = 0;
    create()
    heart()
    mistak = 2
    clearInterval(timer)
    timer = setInterval(() => {
        console.log("interval");
        placeCaf = Math.floor(Math.random() * (over * over))//הגרלת החפרפרת מס' מ-0 עד9
        console.log(placeCaf);
        let y = document.getElementById("bloc").children[placeCaf]//מקבל את הכרטיס במיקום החפרפרת
        console.log(y)
        y.setAttribute("class", "box caf");//הוספת קלאס לעיצוב החפרפרת 
        console.log("vhh")
        y.innerHTML = "🐭"
        console.log("y class:", y.getAttribute('class'));
        setTimeout(() => {
            let y = document.getElementById("bloc").children[placeCaf]
            y.setAttribute("class", "box");
            y.innerHTML = ""
        }, (2000));//מס' שניות לסגירה הכרטיס
    }, 3000);

    setTimeout(() => {
        clearInterval(timer)
    }, 30000);

}
function clickmy() {

    let index = event.srcElement.getAttribute("my-index")
    if (mistak == 0) {
        gameover();
    }
    else {
        if (index == placeCaf) {
            winer++
            point = point + 50;
            document.querySelector("#many").innerHTML = "score :" + `${point}`;
            if (winer == 9) {
                win()
            }
        }
        else {
            let a = document.getElementById("art");
            let y = a.children[mistak]
            y.innerHTML = ""
            mistak--;
            if (mistak == 0) {
                gameover();
            }
        }
    }

}
function gameover() {
    let hwo = document.querySelector("#many").innerHTML = "this pointet" + `${point}`;

    event.srcElement.innerHTML = ''
    alert(`${hwo}` + "המשחק שלך נגמררררררר 🤧🤧🤧ומספר הנקודות שצברת הוא")
    point = 0
    start()
}

function win() {
    point = 0;
    document.querySelector("#many").innerHTML = "this pointet" + `${point}`;
    winer = 0;
    mistak = 2;
    over++;
    console.log("over", over);
    // event.srcElement.innerHTML = ''
    // let y = document.getElementById("art").children[mis]
    //     console.log(y)
    //     y.remove();

    alert("נצחתה עברתה שלב 😍😍😍מגניייב COOOL");


    // show *= 2 / 3;
    // card *= 2 / 3;
    // closecard *= 2 / 3;

    start()
}

