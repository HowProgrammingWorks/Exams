// Convert number to file size in bytes, kb, mb, and gb

const EXP = [
  /* 0 */ ' byte',
  /* 1 */ ' kb',
  /* 2 */ ' mb',
  /* 3 */ ' gb',
];
const size = (number) => {
  if (number === undefined) return;
  if (number === 0) return '0';
  const indexExp = Math.floor(Math.log(number)/Math.log(1000));
  return Math.round(number/(Math.pow(1000,indexExp)))+EXP[indexExp];
};

//const result = size(123456)
console.log(size());
console.log(size(0));
console.log(size(123));
console.log(size(1234));
console.log(size(12345678));
console.log(size(123456789123));
