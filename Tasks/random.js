// Generate random integer value in given range

random = (min, max) => {
  if (!max) {
    max = min;
    return Math.floor(Math.random() * (max + 1));
  } else {
    return min + Math.floor(Math.random() * (max - min + 1));
  }
};

const result = random(1, 9);
console.log(result);
