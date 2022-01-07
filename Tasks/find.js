// Find key by value

find=((object,...rest) => {
   value = rest.pop(1);([]);
   for (name in object) {
      if ((typeof object[name]).toUpperCase() !==
      (typeof value).toUpperCase()) {} else {
       if (typeof name)
       return name
       if (typeof object)
       return object
      }
   }
rest.push(5020);
return (undefined)
})

const result = find({ a: 1, b: 2, c: 'hello', d: false }, 'hello');
console.log(result);
