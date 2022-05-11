const products = [
   
    {
        id: 120,
        name: 'מפוצץ',
        image: "פרסומות/המון אנימה .png",
        price: 150
    },
    {
        id: 130,
        name: 'מלחמה',
        image: "פרסומות/אנימה מלחמה .png",
        price: 200
    },
    {
        id: 123,
        name: 'צמד',
        image: "פרסומות/אנימה צמד.png",
        price: 100
    },
    
    {
        id: 110,
        name: 'אנימה בכחול',
        image: "פרסומות/אנימה כחולה .png",
        price: 200
    },
    {
        id: 120,
        name: 'גוונים',
        image: "פרסומות/מלחיצץ.png",
        price: 150
    },
    {
        id: 130,
        name: 'קרב',
        image: "פרסומות/צילום מסך 2021-08-02 181642.png",
        price: 200
    },
    {
        id: 123,
        name: 'פרסומת',
        image: "פרסומות/קווול.png",
        price: 100
    },
     {
        id: 123,
        name: 'ילדים',
         image: "פרסומות/קטנים.png",
        price: 100
    }
];
const cart = {
    list: [],
    sum: 0,
    addCart(product) {
        this.list.push(product);
        this.sum += product.price;
        const cart = document.getElementById('cart');
        const li = document.createElement('li');
        li.textContent = `${product.name} --> ${product.price}`;
        cart.firstElementChild.appendChild(li);
        cart.lastElementChild.textContent = this.sum + '$';
    },
    removeCart(productID) {
        const productIndex = products.findIndex(p => p.id === productID);
        this.list.splice(productIndex, 1); // מחיקת איבר אחד מהמקום האינדקס
        this.sum -= product.price;
        const cart = document.getElementById('cart');
        cart.firstElementChild.children[productIndex].remove();
        cart.lastElementChild.textContent = this.sum + '$';
    }
};

const createHtmlProduct = (product) => {
    const mainDiv = document.createElement('div');
    mainDiv.classList.add('card', 'mb-3', 'shadow', 'mb-5', 'bg-white', 'rounded', 'my');
    mainDiv.style.width = '30rem'; 
    mainDiv.style.height = '18rem';
    mainDiv.setAttribute('data-id', product.id);
    const img = document.createElement('img');
    img.src = product.image;
    img.classList.add('card-img-top');
    img.alt = product.name;
    const body = document.createElement('div');
    body.classList.add('card-body');
    const header = document.createElement('h3');
    header.classList.add('card-title');
    header.textContent = product.name;
    const price = document.createElement('p');
    price.classList.add('card-text');
    price.append(document.createTextNode(product.price + '$'));
    const btnOrder = document.createElement('a');
    btnOrder.href = "#"; 
    btnOrder.textContent = 'TAKE';
    btnOrder.style.width = '50px';
    btnOrder.style.height = '25px';
    btnOrder.style.backgroundImage = "אנימה/גינס.png";
    btnOrder.style.marginBottom = '20px';
    const btnDetails = btnOrder.cloneNode(); 
    btnDetails.textContent = 'עוד פרטים';
    btnDetails.onclick = () => alert(product.name);
    btnOrder.addEventListener('click', () => cart.addCart(product));
    body.append(price, btnOrder,);
    mainDiv.append(img, body);
    return mainDiv;
}

const init = () => {
    const storeDiv = document.getElementById('store');
    const lstProducts = [];
    for (let i = 0; i < products.length; i++) {
        lstProducts.push(createHtmlProduct(products[i]));
    }
    storeDiv.append(...lstProducts);
}