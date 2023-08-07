 function getLength(obj: string | any[]):void {
    if (Array.isArray(obj)){
        console.log(obj.length);
    }
    else {
        console.log(obj.length);
      }
 }               

 getLength("nirva");
 getLength([1,2,3,4,5]);


 let notsure: any=4;
 notsure.ifItExist();
 notsure.toFixed();