let gameboard = [];
let allFlags = 0;

function GameObject() {


    this.bomb = false;
    this.flag = false;
    this.number = 0;
    this.open = false;

}

function start() {
    for (let i = 0; i < 80; i++) {
        gameboard.push(new GameObject())
    }
    console.log(gameboard)

    for (let i = 0; i < 10; i++) {
        let placeInTheGameboard;
        do {
            placeInTheGameboard = Math.floor(Math.random() * 80)
        } while (gameboard[placeInTheGameboard].bomb == true);

        // let placeInTheGameboard = Math.floor(Math.random() * 80)
        // while (gameboard[placeInTheGameboard].bomb == true) {
        //     placeInTheGameboard = Math.floor(Math.random() * 80)
        // }
        gameboard[placeInTheGameboard].bomb = true;

        //hw: count the number of the bombs
        if (placeInTheGameboard > 9) {
            gameboard[placeInTheGameboard - 10].number++;
            if (placeInTheGameboard % 10 > 0) {
                gameboard[placeInTheGameboard - 11].number++
                // gameboard[placeInTheGameboard - 1].number++
            }
            if (placeInTheGameboard % 10 < 9) {
                //  gameboard[placeInTheGameboard + 1].number++;
                gameboard[placeInTheGameboard - 9].number++;
            }
        }
        if (placeInTheGameboard < 70) {
            gameboard[placeInTheGameboard + 10].number++;
            if (placeInTheGameboard % 10 > 0) {
                gameboard[placeInTheGameboard + 9].number++
                //   gameboard[placeInTheGameboard - 1].number++
            }
            if (placeInTheGameboard % 10 < 9) {
                gameboard[placeInTheGameboard + 11].number++;
                //   gameboard[placeInTheGameboard + 1].number++;
            }
        }
        if (placeInTheGameboard % 10 < 9) {
            gameboard[placeInTheGameboard + 1].number++
        }
        if (placeInTheGameboard % 10 > 0) {
            gameboard[placeInTheGameboard - 1].number++
        }
    }

    console.log(gameboard)



    //draw the mines wipper

    gameboard.forEach((item, index) => {
        let e = document.createElement("div");
        e.setAttribute("class", "squre close");
        e.style.top = `${Math.floor(index / 10) * 50}px`;
        e.style.left = `${Math.floor(index % 10) * 50}px`
        e.setAttribute('my-index', index);

        //click
        e.addEventListener('click', clickMe)
        //right click- context menu
        e.addEventListener('contextmenu', () => {
            event.preventDefault();
            let indexOfClick = event.srcElement.getAttribute('my-index');
            if (gameboard[indexOfClick].flag == false) {
                if (allFlags < 10) {
                    gameboard[indexOfClick].flag = true;
                    allFlags++;
                    event.srcElement.innerHTML = "🏴‍☠️"
                }
            }
            else {
                gameboard[indexOfClick].flag = false;
                allFlags--;
                event.srcElement.innerHTML = ""
            }

        })

        document.querySelector("#allBtns").appendChild(e);
    });
}

function clickMe() {
    let indexOfClick = event.srcElement.getAttribute('my-index');

    if (gameboard[indexOfClick].bomb == false) {
        if (gameboard[indexOfClick].number == 0) {
            event.srcElement.innerHTML = ''
            showMy(indexOfClick);
        }
        else {
            event.srcElement.innerHTML = gameboard[indexOfClick].number;
        }
        gameboard[indexOfClick].open = true;
        event.srcElement.setAttribute('class', 'squre open')
    }
    //if bomb==true
    else {
        let allBombs = [];
        gameboard.map((item, i) => {
            if (item.bomb == true) {
                allBombs.push({ index: i, value: item.flag })
            }
        });


        allBombs.forEach(b => {
            let allBtns = document.getElementById("allBtns").children
            for (let i of allBtns) {
                if (i.getAttribute("my-index") == b.index) {
                    i.setAttribute('class', 'squre bomb');
                    i.innerHTML = "💥"
                }
            }

        })
    }
}
function showMy(indexstart) {
    if (gameboard[indexstart].open == true) {
        return;
    }

    if (gameboard[indexstart].number != 0) {
        document.getElementById('allBtns').children[indexstart].setAttribute('class', 'squre open')
        document.getElementById('allBtns').children[indexstart].innerHTML = gameboard[indexstart].number
        gameboard[indexstart].open = true
        return;
    }
    document.getElementById('allBtns').children[indexstart].setAttribute('class', 'squre open')
    gameboard[indexstart].open = true

    if (indexstart > 9) {
        showMy(indexstart - 10)
        if (indexstart % 10 > 0) {
            showMy(indexstart - 11);
        }
        if (indexstart % 10 < 9) {
            showMy(indexstart - 9);
        }
    }
    if (indexstart < 70) {
        showMy(indexstart + 10);
        if (indexstart % 10 > 0) {
            showMy(indexstart + 9)

        }
        if (indexstart % 10 < 9) {
            showMy(indexstart + 11)

        }
    }
    if (indexstart % 10 < 9) {
        showMy(indexstart + 1)

    }
    if (indexstart % 10 > 0) {
        showMy(indexstart - 1)
    }
}