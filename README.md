# Testing Blazor Applications with Playwright

This is Repo for Pune Tech Community - .NET Conf, Pune 2022 Demos

## Date Time: 17-Dec-2022 at 01:00 PM IST

## Event URL: [https://www.meetup.com/pune-tech-community/events/289618681](https://www.meetup.com/pune-tech-community/events/289618681)

![Viswanatha Swamy P K |150x150](./Documentation/Images/ViswanathaSwamyPK.PNG)

Reference(s):
> [Testing Blazor Applications with Playwright](https://www.youtube.com/watch?v=gBky9_AskNQ&list=PLdo4fOcmZ0oVlqu_V8EXUDDnPsYwemxjn&index=24)

### Pre-requisites

> 1. VS Code
> 1. VS 2022
> 1. .NET 6 / .NET 7

### Prior Knowledge

> 1. C# (.NET 6 / .NET 7)
> 1. Blazor Server
> 1. Automated Testing
> 1. MS Test

### Assumptions

> 1. NIL

## Technology Stack

> 1. .NET 6 / .NET 7

## Information

![Information | 100x100](./Documentation/Images/Information.PNG)

## What are we doing today?

> 1. Explore Azure Event Grid
> 1. Discover event schemas
> 1. Explore event delivery durability
> 1. Control access to events
> 1. Receive events by using webhooks
> 1. Filter events
> 1. Exercise: Route custom events to web endpoint by using Azure CLI
> 1. Discover Azure Event Hubs
> 1. Explore Event Hubs Capture
> 1. Scale your processing application
> 1. Control access to events
> 1. Perform common operations with the Event Hubs client library
> 1. Q & A

### Please refer the [**Source code**](https://github.com/vishipayyallore/BlazorApp-PlaywrightDemo) for today's session code

---

![Information | 100x100](./Documentation/Images/SeatBelt.PNG)

---

## Explore Azure Event Grid

> 1. Discussion and Demo

**Reference(s):**

> 1. [https://docs.microsoft.com/en-us/azure/event-grid/overview](https://docs.microsoft.com/en-us/azure/event-grid/overview)

## Hands on with Azure Event Grid using Portal

> 1. Discussion and Demo

**Azure Resources for Storage EventGrid WebHook**
![Azure Resources for Storage EventGrid WebHook | 100x100](./Documentation/Images/AzResources_Storage_EventGrid_WebHook.PNG)

**Storage Events passed to EventGrid which sends to WebHook**
![Storage EventGrid WebHook | 100x100](./Documentation/Images/Storage_EventGrid_WebHook.PNG)

## Discover event schemas

> 1. Discussion and Demo

![Event Schema | 100x100](./Documentation/Images/Event_Schema.PNG)

![Event Schema | 100x100](./Documentation/Images/Event_Schema_1.PNG)

## Explore event delivery durability

> 1. Discussion and Demo

```AzureCLI
eventgridname=egt-for-az-funcs
rgname=rg-az204-eventbased-dev-001
event='[ {"id": "'"$RANDOM"'", "eventType": "recordInserted", "subject": "myapp/vehicles/motorcycles", "eventTime": "'`date +%Y-%m-%dT%H:%M:%S%z`'", "data":{ "make": "Ducati", "model": "Monster V1"},"dataVersion": "1.0"} ]'

endpoint=$(az eventgrid topic show --name $eventgridname -g $rgname --query "endpoint" --output tsv)

key=$(az eventgrid topic key list --name $eventgridname -g $rgname --query "key1" --output tsv)

curl -X POST -H "aeg-sas-key: $key" -d "$event" $endpoint
```

![Event Delivery Durability | 100x100](./Documentation/Images/Event_DeliveryDurability.PNG)

![Azure Func Processing the Events | 100x100](./Documentation/Images/Event_T0_AzureFunc.PNG)

![Azure Func Processing the Events | 100x100](./Documentation/Images/Azure_Func_Logs.PNG)

## Control access to events

> 1. Discussion and Demo

## Receive events by using webhooks

> 1. Discussion and Demo

![Subscription Validation | 100x100](./Documentation/Images/SubscriptionValidation.PNG)

## Filter events

> 1. Discussion and Demo

![Filtering Events | 100x100](./Documentation/Images/Filter_Demo.PNG)

## Exercise: Route custom events to web endpoint by using Azure CLI

> 1. Discussion and `LIVE Demo`

## Discover Azure Event Hubs

> 1. Discussion and Demo

## Explore Event Hubs Capture

> 1. Discussion and Demo

## Scale your processing application

> 1. Discussion and Demo

## Control access to events

> 1. Discussion and Demo

## Perform common operations with the Event Hubs client library

> 1. Discussion and Demo

---

## SUMMARY / RECAP / Q&A

---

> 1. SUMMARY / RECAP / Q&A
> 2. Any open queries, I will get back through meetup chat/twitter.

---

## What is Next? Session `21` of `21` Sessions on Aug 24, 2022

### AZ-204 |Implement user authentication and authorization

> 1. Explore the Microsoft identity platform
> 1. Implement authentication by using the Microsoft Authentication Library
> 1. Implement shared access signatures
> 1. Explore Microsoft Graph API
> 1. Mini Project(s)
> 1. Q & A
