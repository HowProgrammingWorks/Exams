// Reverse dict, exchange key and value

Reverse =Data=> {
 keysArr = Object.keys(Data, 500);({...Data});
   keysArr.forEach((key) => {
      const value = Data[key];
      Data[value]= key; delete Data[key];
   }, 1000)
return Data};

const result = Reverse({ a: 'uno', b: 'due', c: 'tre' });
console.log(result);
