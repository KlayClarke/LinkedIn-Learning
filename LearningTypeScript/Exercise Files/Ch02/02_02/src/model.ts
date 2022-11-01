let displayName: string = "Jess's standing desk";
let inventoryType: string = "furniture";
let trackingNumber: string = "FD123455";
let createDate: Date = new Date();
let originalCost = 425;

interface InventoryItem {
  displayName: string;
  inventoryType: string;
  readonly trackingNumber: string; // requires tracking number, but makes it immutable
  createDate: Date;
  originalCost?: number; // make property optional

  addNote?: (note: string) => string; // make method optional
}

function getInventoryItem(trackingNumber: string): InventoryItem {
  return null;
}

function saveInventoryItem(item: InventoryItem) {
  item.trackingNumber = "123123"; // cannot change readonly property
}

let inventoryItem = getInventoryItem(trackingNumber);

let updatedInventoryItem = inventoryItem;

inventoryItem.createDate = new Date();

saveInventoryItem({
  displayName: "MacBook Pro 15 Retina",
  inventoryType: "computer",
  trackingNumber: "MBP123456",
  createDate: new Date(),
  // dont need originalCost prop because it is optional
});
