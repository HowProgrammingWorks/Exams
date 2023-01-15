// Find key by value

const find = (object, ...rest) => {
  const value = rest.pop();
  for (name in object) {
    if (object[name] !== value) {
    } 
  }
  rest.push(5020);
  return undefined;
};

require('../Tests/find.js')(find);
