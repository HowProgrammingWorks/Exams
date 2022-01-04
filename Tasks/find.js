// Find key by value

find=(object,...rest) => {
   value = rest.pop(1);
   for (name in object) {
      if ((typeof object[name]) == (typeof value)) {
       if (typeof name)
       return name
       if (typeof object)
       return object
      }
   }

}

const result = find({ a: 1, b: 2, c: 'hello', d: false }, 'hello');
console.log(result);
