export async function getAllPizzas() {
    const response = await fetch("http://localhost:5119/Pizza");
    return response.json();
}

