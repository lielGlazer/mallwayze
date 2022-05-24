export class Store {
    CodeStore: number;
    PlaceCode: number;
    NameStor: string='';
    Sale: boolean=false;
    link?: string=''



    constructor(c: number, p: number, n: string, s: boolean, l?: string) {
        this.CodeStore = c;
        this.NameStor = n;
        this.PlaceCode = p;
        this.Sale = s;
        this.link = (l != undefined ? l : '');
    }
}


