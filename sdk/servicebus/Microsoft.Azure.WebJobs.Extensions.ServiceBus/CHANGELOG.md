# Release History

## 5.6.0-beta.1 (Unreleased)

### Features Added

- Added ability to register a callback for ` SessionInitializingAsync` and `SessionClosingAsync` to the `ServiceBusOptions`. _(A community contribution, courtesy of [danielmarbach](https://github.com/danielmarbach))_

### Breaking Changes

### Bugs Fixed

### Other Changes

## 5.5.1 (2022-06-07)

### Bugs Fixed

- Fixed race condition when starting up function app.

## 5.5.0 (2022-05-16)

### Bugs Fixed

- Updated dependency on `Azure.Messaging.ServiceBus` to benefit from bug fix.
- Messages will now be abandoned if the function invocation throws for multiple dispatch functions. This was already the behavior for single dispatch functions.

## 5.4.0 (2022-05-10)

### Features Added

- Added the `ServiceBusReceiveActions` type to support receiving additional messages from a function invocation.
- Added the ability to bind to the `SessionId` property.

## 5.3.0 (2022-03-09)

### Acknowledgments
Thank you to our developer community members who helped to make the Service Bus client library better with their contributions to this release:

- Daniel Marbach  _([GitHub](https://github.com/danielmarbach))_

### Features Added

- Added the ability to renew message and session locks using the `ServiceBusMessageActions` and `ServiceBusSessionActions`.

### Bugs Fixed

- Ignore scheduled/deferred messages when computing scale monitor metrics. _(A community contribution, courtesy of [danielmarbach](https://github.com/danielmarbach))_

## 5.2.0 (2021-12-08)

### Features Added

- Add listener details.
- Add protected constructors to `ServiceBusMessageActions` and `ServiceBusSessionMessageActions` for mocking.

### Bugs Fixed

- Make `ServiceBusMessageActions` thread-safe.

## 5.1.0 (2021-11-10)

### Features Added
- Added `EnableCrossEntityTransactions` option
- Added ability to bind to `ServiceBusClient`

## 5.0.0 (2021-10-21)

### Features Added
- Added DynamicConcurrency support.
- General availability of Microsoft.Azure.WebJobs.Extensions.ServiceBus 5.0.0.

## 5.0.0-beta.6 (2021-09-07)

### Features Added
- Support binding to `BinaryData` instances.

## 5.0.0-beta.5 (2021-07-07)

### Breaking Changes
- Renamed `ServiceBusEntityType` property to `EntityType`.
- Renamed `messageActions` and `sessionActions` parameters to `actions` in `MessageProcessor` and `SessionMessageProcessor`.
- Renamed `MaxBatchSize` to `MaxMessageBatchSize` in `ServiceBusOptions`.

## 5.0.0-beta.4 (2021-06-22)

### Added
- Added `AutoCompleteMessages` property to `ServiceBusTriggerAttribute` which allows configuring autocompletion at the function level.

### Key Bug Fixes
- Fix binding for DateTime parameters
- Avoid exception that occurred when a function settles messages and `AutoCompleteMessages` is true for multiple dispatch functions.
- Avoid null reference exception that could occur when no messages are available for a multiple dispatch function.

## 5.0.0-beta.3 (2021-05-18)

### Added
- Added `JsonSerializerSettings` property to `ServiceBusOptions`.

### Breaking Changes
- Made `Constants` class internal.
- Made `ServiceBusWebJobsStartup` class internal.
- Renamed `EntityType` to `ServiceBusEntityType`.
- Removed `receiver` parameter from `MessageProcessor` constructor.
- Removed `client` parameter from `SessionMessageProcessor` constructor.

### Key Bug Fixes
- The web proxy specified in configuration is now respected.
- Binding to JObject is now supported.

## 5.0.0-beta.2 (2021-04-07)

### Added
- Add AAD support

### Breaking Changes
- Changed the API signatures for the methods in `MessagingProvider`.
- Added `receiver` parameter to `MessageProcessor` constructor.
- Added `client` parameter to `SessionMessageProcessor` constructor.

## 5.0.0-beta.1 (2021-03-23)

- The initial release of Microsoft.Azure.WebJobs.Extensions.ServiceBus 5.0.0
