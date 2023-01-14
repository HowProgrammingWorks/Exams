// Generate random integer value in given range

const random = (max, min) => min + Math.floor(Math.random() * (max - min));
require('../Tests/random.js')(random);
