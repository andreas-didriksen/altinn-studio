import { SagaIterator } from 'redux-saga';
import { fork } from 'redux-saga/effects';
import { watchStartInitialDataTaskQueueSaga } from './dataTask/dataTaskQueueSagas';
import { watchStartInitialAppTaskQueueSaga } from './appTask/appTaskQueueSagas';

export default function* queueSagas(): SagaIterator {
  yield fork(watchStartInitialDataTaskQueueSaga);
  yield fork(watchStartInitialAppTaskQueueSaga);
}
