export const getRandomItem = (item: any[]) => {
  return item[Math.floor(Math.random() * item.length)];
};

export const getRandomDate = () => {
  const months = [
    'January',
    'February',
    'March',
    'April',
    'May',
    'June',
    'July',
    'August',
    'September',
    'October',
    'November',
    'December'
  ];

  const month = getRandomItem(months);

  const dates = [];
  const firstDay = 1;
  let lastDay = 28;
  switch (month) {
    case 'January':
    case 'March':
    case 'May':
    case 'July':
    case 'August':
    case 'October':
    case 'December':
      lastDay = 31;
      break;
    case 'April':
    case 'June':
    case 'September':
    case 'November':
      lastDay = 30;
      break;
    case 'February':
      lastDay = 28;
  }
  for (let i = firstDay; i <= lastDay; i++) {
    dates.push(i);
  }

  return {
    currentMonth: month,
    currentDate: getRandomItem(dates)
  };
};

export const getRandomisedNum = (lowNum: number, highNum: number) => {
  return Math.floor(Math.random() * highNum) + Math.floor(lowNum);
};
