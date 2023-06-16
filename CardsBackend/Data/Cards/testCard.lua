setMetadata({
    name = "Hello World!",
    health = 2,
    power = 3,
    description = "[b]yep[/b]: cock",
    cost = 8
});

function init(cardData)
    cardData.Name = "Test Card"
    cardData.Health = 3
    cardData.Power = 2
    cardData.Cost = 0
end

setTrigger("init", init);
    
    