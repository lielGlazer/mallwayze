
const drow = [
    {
        id =10,
        name ="עניים ",
        image ="תמונות/droww/1 (2).jpg",
        cost =120,
    },
    {
        id =20,
        name ="חצי  ",
        image ="תמונות/droww/3.jpg",
        cost =20,
    },
    {
        id =30,
        name ="אריה  ",
        image ="תמונות/droww/אריה.jpg",
        cost =200,
    },
    {
        id =40,
        name ="ברבי ",
        image ="תמונות/droww/ברבי.jpg",
        cost =120,
    },
    {
        id =50,
        name ="מעבר חצוי",
        image ="תמונות/droww/חצי.jpg",
        cost =300,
    },
    {
        id =60,
        name ="כיתובים  ",
        image ="תמונות/droww/ליאל.jpg",
        cost =600,
    },
    {
        id =70,
        name ="מאופרת  ",
        image ="תמונות/droww/מאופרת.jpg",
        cost =200,
    },
    {
        id =80,
        name ="מגניב  ",
        image ="תמונות/droww/מטורף.jpg",
        cost =500,
    },
    {
        id =90,
        name =" מתוקהה:)",
        image ="תמונות/droww/מתוקה.jpg",
        cost =260,
    },
    {
        id =100,
        name ="מתוקי ",
        image ="תמונות/droww/מתוקי.jpg",
        cost =300,
    }
]
const cart = {
    sum: 0,
    list:[],
}
const addToCart = (drow) => {
    cart.sum += drow.cost;
    cart.list.push(drow);
}





    
    
