export async function getAllOrders() {
    const response = await fetch("http://localhost:5119/Order");
    return response.json();
}

