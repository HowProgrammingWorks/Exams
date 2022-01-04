// Convert number to file size in bytes, kb, mb, and gb

let size=number=>{
  if (number === undefined) return;
  if (number === 0) return '0';
  const exp = Math.floor(Math.log(number)/Math.log(1000));
  if(exp===0) return number + ' byte';
  if(exp===1) return Math.round(number / 1000) + ' kb';
  if(exp===2) return Math.round(number / 1000000) + ' mb';
  return Math.round(number / 1000000000) + ' gb';
}

//const result = size(123456)
console.log(size());
console.log(size(0));
console.log(size(123));
console.log(size(1234));
console.log(size(12345678));
console.log(size(123456789123));
console.log(size(12345678912345));