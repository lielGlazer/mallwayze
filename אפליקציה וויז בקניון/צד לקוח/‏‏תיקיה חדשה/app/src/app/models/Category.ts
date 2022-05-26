export class Category{
    CodeCategory: number;
    NameCategory: string=''
    
    constructor(c: number, n: string) {
        this.CodeCategory = c;
        this.NameCategory = n;
       
    }
}